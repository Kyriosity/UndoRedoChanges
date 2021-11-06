# Intro
Let's improvise the Undo stack, which is practical for most business applications.

Undo/Redo has some other implicit uses than familiar Edit menu:
+ Replace confirmation prompts to prevent "are you sure" fatigue
+ Base wizards on it (or another navigation/browsing)
+ Record macros with it

Actually the thing must provide two operations: **Undo** and **Redo**, but we'll go further with some features and consider how to avoid large copied volumes of data.

# Roadmap

+ Keeping original value
+ Hooks for adding and retrieving data (e.g. creating a copy for referenced types)
+ Undo/redo to some index (skipping two or more steps)
+ Events and Exceptions
+ Timestamping and storing name of the action
+ *To be discussed:* converting undo stack to macros

# Testing
Though TDD is nice, lack of time and sample UI allow us to write not so much tests. (Some experience on implementing the stack facilitates the task too).

## Subject of undo/redo
Our Undo/Redo stack would be a trivial task, unless we look over storing copies of values. HOW WE GONNA UNDO/REDO

Consider, that a subject of undo is huge and/or composite:
+ hi-res bitmap image, where every pixel matters
+ large binary data 
+ large volumes of records
+ long text (akin to *War and Peace*)

The bitmap is pretty good subject for the following considerations. 
An undoable change on it could be just a change of few pixels or flip. If each time a copy of the image would be stored, we will take too much memory even on the biz computer.

Now think about 
+ resize/resamle,
+ adding new areas, 
+ painting with the same color/erasing.
They're just one word action but completely changing the picture.


### Alternatives
On-the-fly compression/archiving could be an easy solution.

Bits-level hash.

There're must be 3d-parties ready solutions.

I haven't so far considered any, since this project is more an excercise than GitHub library.

# Q&A
+ Is stack homogenous?

Yeaps, but generic.
+ Where's `Clear()`? 

Use `new()`.

# Third parties, copyrights and licences
Icons and images are download of [Visual Studio Image Library](https://www.microsoft.com/en-us/download/details.aspx?id=35825). Please refer to its EULA.

Some pieces of code are courtesy of edu and Q&A sites (stackoverflow, codeproject and others).

Start picture that we modify in the application is the courtesy of wikipedia - Malevich's ([Black Square](https://en.wikipedia.org/wiki/Black_Square_(painting)). 


# Offtop
Supermatic *Black Square* is known as *Zero point of painting*. That's why i selected 

There're varying opinions on Pollack's. $200M for Nr. 5
