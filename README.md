# Undo/Redo stack on C#
Let's knock ourselves out to implement Undo, practical for business applications.
```csharp
var story = new Reversible<string>("began");
story.Value = "Mittelspiel";
story.Value = "happy end"
story.Undo();
var middleGame = story.Value;
story.Undo();
var beginning = story.Value;
story.Redo(2);
var conclusion = story.Value;
```

## Implicit application
Undo/Redo may also be handy for other uses than familiar *Edit* menu:
+ replace confirmation prompts to prevent fatigue with "are you sure" click-away
+ be base of wizards (or similar navigation/browsing)
+ record macros

## Roadmap and features
Actually the thing must provide two operations: **Undo** and **Redo**, but let's go further with some stuff like: 

- [ ] ~~Keeping original value~~ // :-1: unrelevant to Undo
- [x] Undo/redo to some index (skipping one or more steps)
- [x] Exceptions and ~~events~~ // override methods and setters to issue or handle events
- [ ] Hooks for adding and retrieving data (e.g. creating a copy for referenced types)
- [ ] Timestamping and naming the actions
- [ ] *Nice to have:* export/import (i.e. serialization and loading)
- [ ] *To be discussed:* Record and issue macros


## Subject of undo/redo
Our Undo/Redo stack would be a trivial task, unless we regard big data volumes.
Discussed in a [separate thema](readme+/big_subjects_of_undo.md).

# Q&A
+ **Is stack homogenous?**

Yeaps, but generic.
+ Where's `Clear()`? 

Use `new()`.
+ **Is stack's limit mandatory?**

Nope. When not specified/applied, no check is done. It's reasonable when the number of actions is predictable.
+ **How to raise events like PropertyChanged for value itself, CanUndo i.a.? Or get hooks, like <code>OnChanged</code>.**
- [x] Override setters and realization methods

+ **Why not to overlaod `=` and get rid of `.Value`**

1) Setting would be ambigous (is it new value of or new object?). Casting would deprive `=` of brevity.
2) `imlicit`\`explicit` operators are static - what about access to instance props and methods?.

# Third parties, copyrights and licences
- Most pictograms and images are bounty of [Visual Studio Image Library](https://www.microsoft.com/en-us/download/details.aspx?id=35825). Please refer to its EULA.

- Some pieces of code are courtesy of edu and Q&A sites (stackoverflow, codeproject and others).

- The app take advantage of renowned 3d party libraries and frameworks, like [fluent assertions](https://fluentassertions.com/).

# Offtopic
Start bitmap, that we'll modify in the WPF application, is Malevich's [Black Square](https://en.wikipedia.org/wiki/Black_Square_(painting)). 

To modify spots of the picture we gonna use strokes akin to those in the works of Jackson Pollock.

Though works of the both artists are subject of heated debates&nbsp;<sup>**_art**</sup>, we apply them here **only** as pretty good random source and random changes.\
(Supermatic *Black Square* is known as *Zero point of painting*. Looks good for our start bitmap.)

&nbsp;&nbsp;<sub><sup>**_b**</sup>&nbsp;&nbsp;from "it's not art at all" up to $140M for [No. 5](https://en.wikipedia.org/wiki/No._5,_1948)</sub>
