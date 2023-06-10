'''
Author: Naiyuan liu
Github: https://github.com/NNNNAI
Date: 2021-11-23 17:03:58
LastEditors: Naiyuan liu
LastEditTime: 2021-11-24 19:00:38
Description: 
'''

import cv2
import torch
import glob
from glob import glob
import fractions
import numpy as np
from PIL import Image
import torch.nn.functional as F
from torchvision import transforms
from models.models import create_model
from models.projected_model import fsModel
from options.test_options import TestOptions
from insightface_func.face_detect_crop_single import Face_detect_crop
from util.videoswap import video_swap
import os

def lcm(a, b): return abs(a * b) / fractions.gcd(a, b) if a and b else 0

transformer = transforms.Compose([
        transforms.ToTensor(),
        #transforms.Normalize([0.485, 0.456, 0.406], [0.229, 0.224, 0.225])
    ])

transformer_Arcface = transforms.Compose([
        transforms.ToTensor(),
        transforms.Normalize([0.485, 0.456, 0.406], [0.229, 0.224, 0.225])
    ])

# detransformer = transforms.Compose([
#         transforms.Normalize([0, 0, 0], [1/0.229, 1/0.224, 1/0.225]),
#         transforms.Normalize([-0.485, -0.456, -0.406], [1, 1, 1])
#     ])


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

    app = Face_detect_crop(name='antelope', root='./insightface_func/models')
    app.prepare(ctx_id= 0, det_thresh=0.6, det_size=(640,640),mode=mode)
    
    listc = 0
     
    path_f = os.path.join(opt.pic_b_path,'*.mov')
    path_f2 = os.path.join(opt.pic_b_path,'*.avi')
    path_f3 = os.path.join(opt.pic_b_path,'*.webm')
    path_f4 = os.path.join(opt.pic_b_path,'*.mp4')
    path_f5 = os.path.join(opt.pic_b_path,'*.wmv')

    with torch.no_grad():
   
        pic_a = opt.pic_a_path
        img_a_whole = cv2.imread(pic_a)
        img_a_align_crop, _ = app.get(img_a_whole,crop_size)
        img_a_align_crop_pil = Image.fromarray(cv2.cvtColor(img_a_align_crop[0],cv2.COLOR_BGR2RGB)) 
        img_a = transformer_Arcface(img_a_align_crop_pil)
        img_id = img_a.view(-1, img_a.shape[0], img_a.shape[1], img_a.shape[2])

        img_id = img_id.cuda()

        img_id_downsample = F.interpolate(img_id, size=(112,112))
        latend_id = model.netArc(img_id_downsample)
        latend_id = F.normalize(latend_id, p=2, dim=1)
        
        for frame_index in list(glob(path_f) + glob(path_f2) + glob(path_f3) + glob(path_f4)+ glob(path_f5)):

            video_swap(frame_index, latend_id, model, app, opt.output_path + '/' +opt.cluster_path , temp_results_dir=opt.temp_path, no_simswaplogo=opt.no_simswaplogo,
                    use_mask=opt.use_mask, crop_size=crop_size, new_model=opt.new_model)
            listc = listc+1
                    
        print('* Done:' + opt.pic_b_path + ' - ' + str(listc))