
import cv2
import torch
import fractions
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


if __name__ == '__main__':
    opt = TestOptions().parse()

    start_epoch, epoch_iter = 1, 0
    crop_size = opt.crop_size

    # torch.nn.Module.dump_patches = True
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

    # logoclass = watermark_image('./simswaplogo/simswaplogo.png')
    if opt.new_model == True:
        model = fsModel()
        model.initialize(opt)
        model.netG.eval()
    else:            
        model = create_model(opt)
        model.eval()

    spNorm =SpecificNorm()
    app = Face_detect_crop(name='antelope', root='./insightface_func/models')
    app.prepare(ctx_id= 0, det_thresh=0.6, det_size=(640,640),mode=mode)

    # with torch.no_grad():
    pic_a = opt.pic_a_path

    img_a_whole = cv2.imread(pic_a)
    img_a_align_crop, _ = app.get(img_a_whole,crop_size)
    # img_a_align_crop_pil = Image.fromarray(cv2.cvtColor(img_a_align_crop[0],cv2.COLOR_BGR2RGB)) 
    # img_a = transformer_Arcface(img_a_align_crop_pil)
    
    
    img = np.array(img_a_align_crop[0], dtype=np.float)
    # img = img_mask * target_image + (1-img_mask) * img
    final_img = img.astype(np.uint8)
    cv2.imwrite(opt.pic_b_path, final_img)

    print(' ')

    print('************ Done ! ************')
