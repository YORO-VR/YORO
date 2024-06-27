import numpy as np

def median(img,mask,kernel):
    img_pad=np.pad(img,((kernel,kernel),(kernel,kernel),(0,0)), 'constant', constant_values=0)
    mask_index = np.argwhere(mask==0)+(kernel, kernel)
    mask_pad=np.pad(mask,((kernel,kernel),(kernel,kernel)), 'constant', constant_values=0)
    result = img_pad.copy()
    half_kernel =int(((kernel)/2))
    for axis in range(3):
        channel = img_pad[:,:,axis]
        for x,y in mask_index:
            img_kernel = channel    [x-half_kernel:x+half_kernel,y-half_kernel:y+half_kernel]
            mask_kernel = mask_pad  [x-half_kernel:x+half_kernel,y-half_kernel:y+half_kernel]
            k = img_kernel[mask_kernel!=0]
            if len(k) ==0: 
                continue
            result[x,y,axis] = np.median(k)
    return  result[kernel:-kernel,kernel:-kernel,:]