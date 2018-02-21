# Laboratory Work No.1



## Purpose

- Learn to work with Win32API

- Understand the basics of event-driven programming

- Choose a PSG to follow through a project



## Requirements

#### Mandatory Objectives

- Choose a **Programming Style Guideline** (PSG) that you'll follow

- Create a **Windows application**

- Add 2 **buttons** to window: one with default styles, one with custom styles
(size, background, text color, font family, font size)

- Add 2 **text** elements to window: one with default styles, one with custom styles
(size, background, text color, font family, font size) *[one of them should be something funny]*

- On windows resize, one of the **texts** should *"reflow"* and be in window's center (vertically and horizontally)


#### Objectives with Points

- Add 2 **text inputs** to window: one with default styles, one with custom styles
(size, background, text color, font family, font size) `(1 pt)`

- Make elements to fit window on resize `(1 pt)` *(hint: you can limit minimal window width and height)*

- Make elements to interact or change other elements (`(1 pt)` each different interactions) `(0-2 pt)`
*(ex. on button click, change text element color or position)*

- Change behavior of different window actions (at least 3). For ex.: on clicking close button,
move window to a random location on display's working space `(1 pt)`

- Write your own PSG (you can take existent one and modify it) and argue why it is better (for you) `(1 pt)`



## Implementation

- [Visual Studio IDE](https://www.visualstudio.com/) used for this project

- [Chosen PSG](https://www.freebsd.org/cgi/man.cgi?query=style&sektion=9&manpath=FreeBSD+5.0-current) -
because it's very similar to my own coding style

- The created **Windows Application** has the following elements:

   + 5 **buttons** - 1 with default style (the `Add` **button**) and 4 with custom styles

   + 4 **text** elements - 2 drawn in `WM_PAINT`
   (the topmost text is completely customized, while the centered one uses the default styles,
   except for its bg and text colors, because of the black background color)
   and 2 are created as `static` elements in `WM_CREATE` (same as before,
   using default styles, except for bg and text colors)
   
   + 2 **text inputs** - the upper one uses default styles and the lower one uses custom styles
      
- Implemented features:

   + The application is fully **responsive**:
       
       - It has a minimum size limit
       
       - With each resize request, the elements are redrawn with new coordinates, relative to
       the new window size
       
       ![min][minwin]
       ![max][maxwin]

    + Elements interact with other elements:
       
       - The upper buttons (along with the **text input** and `Add` button) interact with the centered text,
       changing the color and the text itself based on the pressed button
      
       ![rick][rickclick]
       ![morty][mortyclick]
       ![poopy][poopyclick]
       ![add][addclick]
       
       - The `Submit` button interacts with both the centered text and the `Name` **text input**,
       checking if the user entered their name, or if they chose their favorite character, thus 
       handling the output
       
       ![nochar][nocharsubmit]
       ![noname][nonamesubmit]
       ![ok][oksubmit]
       
    + Overridden default window actions:
    
       - `Close` button click triggers a dialog box (pressing `Yes` will call a `Messagebeep` error sound,
       pressing `No` will close the window)
       
       ![close][close]
       
       - `Minimize`/`Maximize` button click also triggers a dialog box (pressing `Yes` in both cases does nothing)
       
       ![min][minimize]
       ![max][maximize]

    + Music:
    
       - Clicking the 3 upper buttons will also play different sounds (on a different thread, so it will not freeze
       the window while playing)
  
  
       
## Conclusions

In this laboratory work we learnt:

- To create **text** fields, **buttons** and **text inputs**

- To use custom styles on different elements

- To make elements interact with other elements
       
  
  
## References

1. [Programming Windows by Charlez Petzold, 5th edition](https://www.amazon.com/exec/obidos/ISBN=157231995X)

1. [theForger's Win32 API Programming Tutorial](http://www.winprog.org/tutorial/start.html)

1. [StackOverflow](https://stackoverflow.com/)

1. [MSDN](https://msdn.microsoft.com/en-us/library/windows/desktop/ff818516(v=vs.85).aspx)



[minwin]: https://user-images.githubusercontent.com/22482507/36475238-b719db1e-1702-11e8-9d97-38c7f38799bc.PNG "Minimum size"
[maxwin]: https://user-images.githubusercontent.com/22482507/36475250-b8443912-1702-11e8-89e2-90212af9df27.PNG "Maximum size"

[rickclick]: https://user-images.githubusercontent.com/22482507/36475245-b7bf2b0a-1702-11e8-8a58-ada2033048fe.PNG "Clicking Rick button"
[mortyclick]: https://user-images.githubusercontent.com/22482507/36475240-b737d34e-1702-11e8-88c7-123b5e205245.PNG "Clicking Morty button"
[poopyclick]: https://user-images.githubusercontent.com/22482507/36475244-b78fb0c8-1702-11e8-84b3-12eb8e6c649a.PNG "Clicking Mr. Poopybutthole button"
[addclick]: https://user-images.githubusercontent.com/22482507/36475247-b7f53d76-1702-11e8-96d9-3d6b621b3d29.PNG "Clicking Add"

[nocharsubmit]: https://user-images.githubusercontent.com/22482507/36475241-b753ae52-1702-11e8-913c-2525f8aeeb2a.PNG "Clicking Submit without choosing a char"
[nonamesubmit]: https://user-images.githubusercontent.com/22482507/36475242-b774b4b2-1702-11e8-8960-b383158ea1fa.PNG "Clicking Submit without entering your name"
[oksubmit]: https://user-images.githubusercontent.com/22482507/36475246-b7d96a74-1702-11e8-8b30-28750d1ec02e.PNG "Clicking Submit OK"

[close]: https://user-images.githubusercontent.com/22482507/36475248-b8109472-1702-11e8-8924-46291fc5cdcb.PNG "Clicking Close Window"
[minimize]: https://user-images.githubusercontent.com/22482507/36475237-b6fd32d4-1702-11e8-8b69-8d98b4430828.PNG "Clicking Minimize Window"
[maximize]: https://user-images.githubusercontent.com/22482507/36475249-b82a29aa-1702-11e8-90b2-06afdbbb0385.PNG "Clicking Maximize Window"
