# Intro
Let's improvise the Undo stack, which is practical for most business applications.

Actually the thing must provide two operations: Undo and Redo, but we'll go further with some features and consider how to avoid large copied volumes of data in the stacks' storage.

# Features beyond Undo/Redo

+ Keeping original value
+ Hooks for adding and retrieving data
+ Undo/redo in some steps
+ Events
+ Exceptions

# Testing
Though TDD is nice lack of time and sample UI allow us to write not so much tests. (Some experience on implementing it too).

## Subject of undo/redo
Our Undo/Redo stack would be a trivial task, unless we think beyond storing copies of values.

Consider, that a subject of undo is huge and/or composite:
+ hi-res bitmap image, where every pixel matters
+ large binary data 
+ large volumes of records
+ long text (akin to *War and Peace*)

The bitmap is pretty good subject for the following considerations. 
An undoable change on it could be just a change of few pixels or flip. If each time a copy of the image would be stored, we will take too much memory even on the biz computer.

Though archiving or hashing can be applied for such cases, we'll try to develop a kind of script that will apply or rollback the change.

# Q&A
+ Is stack homogenous?

Yeaps, but generic.
+ Where's `Clear()`? 

Use `new()`.

# Third parties, copyrights and licences
Icons and images are download of [Visual Studio Image Library](https://www.microsoft.com/en-us/download/details.aspx?id=35825). Please refer to its EULA.

Start picture that we modify in the application is the courtesy of wikipedia - Malevich's ([Black Square](https://en.wikipedia.org/wiki/Black_Square_(painting)). (*Zero point of painting* for us too.)
