# Laboratory Work No.4



## Purpose

- Windows Timer

- Animation

## Requirements

#### Mandatory Objectives

- Create an animation based on Windows timer which involves at least 5 different drawn objects


#### Objectives with Points

- Increase and decrease animation speed using mouse wheel `(2 pt)`

- Solve flickering problem `(2 pt)`

- Add animated objects which interact with each other `(2-6 pt)`

- Animate a Nyan Cat that leaves a rainbow tail `(Math.floor(+35% for task with interacting objects))`



## Implementation

_Implemented in C#_

- The Main Window has a Big __Button__, which if clicked, spawns a moving Nyan cat (it does not exactly leave a rainbow tail, but I hope it's enough. I mean, look, it moves - that's a start) `(1 pt)` (at least?)

- With the mouse wheel, animation's speed can increase or decrease `(2 pt)`

- The flickering problem is solved thanks to this line of code `(2 pt)`:

   `SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);`

   _Double Buffer is a technique where we draw all our graphic needs to an image stored in the memory (buffer) and after we are done with all our drawing needs we a draw a complete image from the memory onto the screen._
   
- There are animated objects that interact with each other `(3 pt)` (since it's not very rich in animation):

   + Clicking anywhere on the form will spawn a __Dickbutt Pickle Rick__ which moves around the window
   
   + Their collision will trigger a Sound saying `I'M PICKLE RIIIICK`
       
       
## Conclusions

In this laboratory work we learnt:

- To work with __timers__

- To create animations

----

#### Total Points

- `(8 pt)` - __Objectives with Points__ implemented 

- `(1 pt)` - Early submission
  
