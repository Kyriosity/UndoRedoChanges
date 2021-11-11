# Intro
Let's improvise the Undo stack, which is practical for most business applications.

Undo/Redo has also some other implicit uses than familiar Edit menu:
+ replace confirmation prompts to prevent "are you sure"-click-fatigue
+ base wizards on it (or similar navigation/browsing)
+ record macros with it

# Extra features
Actually the thing must provide two operations: **Undo** and **Redo**, but let's go further with some stuff like: 

+ Keeping original value
+ Hooks for adding and retrieving data (e.g. creating a copy for referenced types)
+ Undo/redo to some index (skipping two or more steps)
+ Events and exceptions
+ Timestamping and storing name of the action
+ *Nice to have:* export/import (i.e. serialization and loading)
+ *To be discussed:* converting undo stack to macros

## Subject of undo/redo
Our Undo/Redo stack would be a trivial task, unless we look over storing copies of values.

Consider, that a subject of undo is huge and/or composite:
+ hi-res bitmap image, where every pixel matters
+ large binary data 
+ sophisticated business records
+ long text (akin to *War and Peace*)

The bitmap is pretty good subject for the following considerations. 
A change on it (to undo/redo) could be just few pixels or usual flip/rotate. If each time a copy of the image would be stored, it would take too much memory.

Now think about 
+ resize/resamle,
+ adding new areas, 
+ filling with a solid color, or erasing.
They're just one word action but completely changing the picture. 

To be discussed and developed: some *change scripting* objects.

### Alternatives
+ On-the-fly compression/archiving could be an easy solution.
+ Bits-level hashing.
+ There're must be 3d-parties ready solutions.

I haven't considered any of them, for this project (so far) is more an excercise than a productive GitHub library.

# Q&A
+ Is stack homogenous?

Yeaps, but generic.
+ Where's `Clear()`? 

Use `new()`.
+ Is stack's limit mandatory?

Nope. When not specified/applied, no check is done. Why not when the number of actions is predictable.

# Third parties, copyrights and licences
Icons and images are download of [Visual Studio Image Library](https://www.microsoft.com/en-us/download/details.aspx?id=35825). Please refer to its EULA.

Some pieces of code are courtesy of edu and Q&A sites (stackoverflow, codeproject and others).

Some renowned 3d party libs are used, like *fluent assertions*.

# Offtopic
Start bitmap, that we'll modify in the WPF application, is Malevich's [Black Square](https://en.wikipedia.org/wiki/Black_Square_(painting)). 

To modify spots of the picture we gonna use strokes akin to those in the works of Jackson Pollock.

Though works of the both artists are subject of heated debates&nbsp;<sup>**_art**</sup>, we apply them here **only** as pretty good random source and random changes.\
(Supermatic *Black Square* is known as *Zero point of painting*. Looks good for our start bitmap.)

&nbsp;&nbsp;<sub><sup>**_b**</sup>&nbsp;&nbsp;from "it's not art at all" up to $140M for [No. 5](https://en.wikipedia.org/wiki/No._5,_1948)</sub>
