# Keeping undo for big data objects

Piling a series of primitive values (numbers, bool) is plain. But consider huge and/or composite stuff:
+ hi-res bitmap image,
+ long text with formatting,
+ large binary data,
+ sophisticated business records

It will be memory (performance) hit to store a copy for frequent changes like retouching some pixels on telescope panorama or emphasizing a word in *War and Peace*.

A large bitmap is fairly illustrative. Well, we can store only the changed area, but imagine also operations which are one word but completely "change the picture":
+ flip and rotate,
+ resize/resamle,
+ adding some space, 
+ fill with a solid color / erase.
They're just one word but completely changing the picture. 

To be discussed and developed: some *change scripting* objects.

### Alternatives
+ On-the-fly compression/archiving could be an easy solution.
+ Bits-level hashing.
+ There're must be 3d-parties ready solutions.

I haven't considered any of them, for this project (so far) is more an excercise than a productive GitHub library.
