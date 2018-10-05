# Spectrum Track
## Color and Shape tracking with OpenCVSharp and WinForms
This software was created using OpenCvSharp, an OpenCv C# wrapper, and WinForms from .Net framework. In a basic way, what it does is detect the BLOBs, gather their data and send it through UDP. To have a better understanding of what it’s happening here it’s important to get familiar with what is a BLOB and how we get it.

BLOB stands for Binary Large Object and refers to a group of connected pixels in a binary image. The term “Large” indicates that only objects of a certain size are of interest and that the other “small” binary objects are usually noise, therefore ignored, something that can be controlled with the BLOB area option found in this software. To extract these BLOBs from the image it needs to isolate them in a binary image and to do so we need to provide the software with the range of colours where we can find them, this software works with HSV colour space since it’s probably the best way. Knowing the range, we convert the original image from RGB to HSV and then threshold it, returning a black and white image where the white are the pixels which HSV values are inside the range. Moreover, it’s applied some algorithms, usually referred to as connected component analysis or connected component labelling (e.g. Recursive Grass-Fire Algorithm or Sequential Grass-Fire Algorithm) to label each BLOB.

For the moment, this software can extract the following data from the BLOBs, that will be sent through UDP:
* Countours
* Position (central poition)
* Area
* Perimeter
* Colour
* Shape (square, rectangle, trangle, unidentified)

There’s still a lot of room for improvement both in the performance and the amount data extracted from the BLOBs, something that will be added in future versions.

### UDP
As mentioned before, all the data gather from BLOBs is sent through UDP. In total is sent six datagrams for each BLOB and they have the following structure:
* Contours
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]mesh,sample,X1,Y1,X2,Y2,X3,Y3...Xn,Yn;
* Position
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]place,position,X,Y;
* Area
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]area,value,result;
* Perimeter
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]perimeter,value,result;
* Colour
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]color,hsv,hue-saturation-value;
* Shape
  * [$]tracking|id=XX|label=XX[$$]Spectrum,[$$$]shape,type,shape_result;
  
### Tips and tricks to achieve better results
1. This software works with colours, which means that the better the quality of stream, better the detection. So, make sure you take your time adjusting the filters of the camera to get a clean and sharp image with bright colours.
1. Before starting the colour calibration process, make sure it is in the same environment this software will be used on. Changing places or just changing lights may modify the HSV values perceive by the camera, destroying the detection. However, there’s a big chance it can be fixed by simply working with the camera filter.
1. Shadows are an issue. This is something that may be solved in future versions without you even noticing, but for now, having a shadow over an object colour will change his HSV values which means the software won’t detect it. There are two possible solutions:
  1. When calibrating the colours, check if the colour is being detected with the shadow over it, if not try moving both value and saturation bars till it detects it properly.
  1. If the previous step doesn’t work, add to the list of detections the same colour with the shadow over it.
1. Constant and correct detection of shapes may be hard to achieve because of BLOB changes that may be caused by illumination variations. To improve detection, it’s essential that the object’s shape is properly defined. On top of that, point 1 of this section is very important.

## Together with this software I developed a unity 3D package that will be available in the Unity Asset Store soon.
