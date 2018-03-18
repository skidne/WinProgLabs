# Laboratory Work No.2



## Purpose

- Advanced Form Elements

- Child Windows

- Basics of Working With Keyboard


## Requirements

#### Mandatory Objectives

- Display a dialog box on some event (ex. on clicking some button)

- Add a system menu to your application with at least 3 items (add actions to that items)

- Add a scroll bar that will change any visible parameter of any other element (color of a text)

- Hook keyboard input. Add 2 custom events for 2 different keyboard combinations (ex. change window background on ctrl+space)


#### Objectives with Points

- Add a listbox and attach some events when any element is accessed (clicked) `(2 pt)`

- Add 2 scroll bars that will manage main window size or position  `(1 pt)`

- Customize your application by adding an icon and using different cursor in application `(1 pt)`

- Use a scroll bar to scroll through application working space. Scroll should appear only when necessary (eg. when window width is smaller than 300px) `(1 pt)`



## Implementation

- The `Click Me` button when clicked displays a __Dialog Box__:

   + In the __Dialog Box__ is a __ListBox__ containing 3 elements, which when clicked, display the element's text alongside `(2 pt)`
   
- The __Menu__ in the Main Window has 4 elements (some are nested), that each display a `MessageBox`

- The upper __Scroll Bar__ changes the color of the background (from black to white)

- Pressing `Alt` + `Up` maximizes the window, whereas pressing `Alt` + `Down` minimizes it

- The last 2 __Scroll Bars__ take care of resizing the window (the upper - width, lower - height) `(1 pt)`

- The application has 2 different custom __icons__ and a custom __cursos__ `(1 pt)`


       
## Conclusions

In this laboratory work we learnt:

- To create **scroll bars**, **dialog boxes** and **menus**

- To add custom __icons__ and __cursors__

- To handle keyboard input


----

#### Total Points

- `(4 pt)` - __Objectives with Points__ implemented 
       
  
  
## References

1. [Programming Windows by Charlez Petzold, 5th edition](https://www.amazon.com/exec/obidos/ISBN=157231995X)

1. [theForger's Win32 API Programming Tutorial](http://www.winprog.org/tutorial/start.html)

1. [StackOverflow](https://stackoverflow.com/)

1. [MSDN](https://msdn.microsoft.com/en-us/library/windows/desktop/ff818516(v=vs.85).aspx)
