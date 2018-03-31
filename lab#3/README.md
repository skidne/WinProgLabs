# Laboratory Work No.3



## Purpose

- Basics of Working with Mouse

- GDI Primitives

- Bezier Curve


## Requirements

#### Mandatory Objectives

- Draw few lines of different colors and weights

- Draw a Bezier curve

- Draw few plane objects (ex. circle, square, pie, polygon...) of different colors, weights, filled and not

- Draw 2 different objects using mouse


#### Objectives with Points

- Draw a custom bitmap image `(1 pt)`

- Add a switch (button, select list...) that will change mouse ability to draw objects `(2 pt)`

- Draw a Bezier curve using mouse `(1 pt)`

- Fill an object with a gradient `(1 pt)`

- Delete objects using mouse clicking `(2 pt)`

- Use mouse as an eraser of:

   + a fixed width `(1 pt)`
   
   + an adjustable width `(2 pt)`
   
- Zoom in and out application working area using keyboard `(2 pt)`



## Implementation

_Implemented in C#_

- The __ImageBox__ in the top of the toolbar opens a __Color Picker Dialog__, where the user can choose the color they want

- The application can draw the following objects `(2 pt)`:
   
   + Free lines (__Pen__ button)
   
   + Straight lines (__Line__ button)
   
   + Rectangles (__Rectangle__ button), can be unfilled, filled with a simple color and filled with a color gradient `(1 pt)`
   
   + Circles (__Circle__ button), same as __Rectangle__
   
   + Bezier curves (__Bezier__ button), only 4 points, created by mouse clicks `(1 pt)`
   
   + Bitmap Images (__Image__ button), uses an __Open File Dialog__ to let the user choose an image, then the image is drawn on the position specified by the user's click `(1 pt)`
   
- The __Eraser__ can only be used "freely" (like the __Pen__)

   + It has adjustable width (as the rest of the primites have) `(2 pt)`
   

## SHOW OFF TIME

- Made only with the __Pen__ tool

   ![pen](https://user-images.githubusercontent.com/22482507/38168163-b4febcfa-354d-11e8-84e8-1fc2ccdfd750.PNG)
   
- Made only with the __Line__ tool

   ![line](https://user-images.githubusercontent.com/22482507/38168166-bef522ee-354d-11e8-9552-dc3254f51054.PNG)
   
- Made only with the __Rectangle__ tool (simple fill and gradient used)

   ![rect](https://user-images.githubusercontent.com/22482507/38168170-c3c7dfb4-354d-11e8-93fc-402bb695b6e2.PNG)

- Made only with the __Circle__ tool (unfilled, filled and gradient)

   ![circle](https://user-images.githubusercontent.com/22482507/38168172-c581103c-354d-11e8-8a84-2f93c9c157d6.PNG)
   
- Made with __Image__ and __Pen__ tools

   ![img](https://user-images.githubusercontent.com/22482507/38168173-c7524228-354d-11e8-8b7e-40539aacb4f1.PNG)
       
       
## Conclusions

In this laboratory work we learnt:

- To create __GDI__ primitives

- To draw bitmaps

- To draw Bezier curves

----

#### Total Points

- `(7 pt)` - __Objectives with Points__ implemented 

- `(1 pt)` - Early submission
  
