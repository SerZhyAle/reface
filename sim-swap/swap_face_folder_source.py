'''
Author: Naiyuan liu
Github: https://github.com/NNNNAI
Date: 2021-11-23 17:03:58
LastEditors: Naiyuan liu
LastEditTime: 2021-11-24 19:19:43
Description: 
'''

import cv2
import torch
import fractions
import glob
import time
import numpy as np
from PIL import Image
import torch.nn.functional as F
from torchvision import transforms
from models.models import create_model
from datetime import datetime

from models.projected_model import fsModel

from options.test_options import TestOptions
from insightface_func.face_detect_crop_single import Face_detect_crop
from util.reverse2original import reverse2wholeimage
import os
from util.add_watermark import watermark_image
from util.norm import SpecificNorm
from parsing_model.model import BiSeNet
import warnings
warnings.filterwarnings("ignore")

from util.swap_new_model import swap_result_new_model

def lcm(a, b): return abs(a * b) / fractions.gcd(a, b) if a and b else 0

transformer_Arcface = transforms.Compose([
        transforms.ToTensor(),
        transforms.Normalize([0.485, 0.456, 0.406], [0.229, 0.224, 0.225])
    ])

def _totensor(array):
    tensor = torch.from_numpy(array)
    img = tensor.transpose(0, 1).transpose(0, 2).contiguous()
    return img.float().div(255)
if __name__ == '__main__':
    opt = TestOptions().parse()

    start_epoch, epoch_iter = 1, 0
    crop_size = opt.crop_size

    torch.nn.Module.dump_patches = True
    '''
    if crop_size == 512:
      if opt.new_model == True:
          opt.name = '512_new'
          opt.Gdeep = True
          mode = 'None'
      else:
        opt.name = str(512)
        opt.which_epoch = 550000
        mode = 'ffhq'
    else:
        mode = 'None'

    if crop_size == 224:
      if opt.name == 'people':
          opt.new_model = False
    '''
    if crop_size == 512:
        opt.which_epoch = 550000
        opt.name = '512'
        mode = 'ffhq'
    else:
        mode = 'None'
     
    logoclass = watermark_image('./simswaplogo/simswaplogo.png')
    '''
    if opt.new_model == True:
        model = fsModel()
        model.initialize(opt)
        model.netG.eval()
    else:            
    '''
    model = create_model(opt)
    model.eval()

    spNorm =SpecificNorm()
    app = Face_detect_crop(name='antelope', root='./insightface_func/models')
    app.prepare(ctx_id= 0, det_thresh=0.6, det_size=(640,640),mode=mode)
    
    path_f = os.path.join(opt.pic_b_path,'*.jp*')
    path_f2 = os.path.join(opt.pic_b_path,'*.png')
    path_f3 = os.path.join(opt.pic_b_path,'*.bmp')
    path_f4 = os.path.join(opt.pic_b_path,'*.jfif')
    path_f5 = os.path.join(opt.pic_b_path,'*.webp')

    with torch.no_grad():
    
        pic_a = opt.pic_a_path

        img_a_whole = cv2.imread(pic_a)
        img_a_align_crop, _ = app.get(img_a_whole,crop_size)
        img_a_align_crop_pil = Image.fromarray(cv2.cvtColor(img_a_align_crop[0],cv2.COLOR_BGR2RGB)) 
        img_a = transformer_Arcface(img_a_align_crop_pil)
        img_id = img_a.view(-1, img_a.shape[0], img_a.shape[1], img_a.shape[2])

        # convert numpy to tensor
        img_id = img_id.cuda()

        #create latent id
        img_id_downsample = F.interpolate(img_id, size=(112,112))
        latend_id = model.netArc(img_id_downsample)
        latend_id = F.normalize(latend_id, p=2, dim=1)
        
        listc = 0

        if opt.use_mask:
            n_classes = 19
            net = BiSeNet(n_classes=n_classes)
            net.cuda()
            save_pth = os.path.join('./parsing_model/checkpoint', '79999_iter.pth')
            net.load_state_dict(torch.load(save_pth))
            net.eval()
        else:
            net =None
#
        projectFiles = list(glob.glob(path_f) + glob.glob(path_f2) + glob.glob(path_f3) + glob.glob(path_f4)+ glob.glob(path_f5))
        for frame_index in projectFiles:
     
            ############## Forward Pass ######################

            pic_b = frame_index
            img_b_whole = cv2.imread(pic_b)

            try:
                detect_results = app.get(img_b_whole,crop_size)

                if detect_results is not None:
                    
                    img_b_align_crop_list =detect_results[0]
                    b_mat_list = detect_results[1]
                    
                    # detect_results = None
                    swap_result_list = []

                    b_align_crop_tenor_list = []

                    for b_align_crop in img_b_align_crop_list:

                        b_align_crop_tenor = _totensor(cv2.cvtColor(b_align_crop,cv2.COLOR_BGR2RGB))[None,...].cuda()

                        if opt.new_model == True:
                          swap_result = swap_result_new_model(b_align_crop_tenor, model, latend_id)
                        else:
                          swap_result = model(None, b_align_crop_tenor, latend_id, None, True)[0]

                        swap_result_list.append(swap_result)
                        b_align_crop_tenor_list.append(b_align_crop_tenor)
                        
                    now = datetime.now()
                    newname =opt.cluster_path + now.strftime("%Y%m%d%H%M%S%f")+'.png'            
                    reverse2wholeimage(b_align_crop_tenor_list, swap_result_list, b_mat_list, crop_size, img_b_whole, logoclass, \
                        os.path.join(opt.output_path, newname), opt.no_simswaplogo,pasring_model =net,use_mask=opt.use_mask, norm = spNorm)

                    print(' ' + frame_index + ' -> ' + newname)
                    listc = listc+1
                else:
                    print(' ' + frame_index + ' Skiped! ')
            except:
                print(' '+ frame_index + ' error! ')

        print('* Done:' + opt.pic_b_path + ' - ' + str(listc))
