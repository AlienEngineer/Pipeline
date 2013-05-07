Pipeline
========

C# implementation of a generic pipeline.


```C#

// setup
var setup = Config
  .Stage(new ParseFromString())
  .Stage(new DivideByPI())
  .Stage(new Format());
  
// create
var pipeline = Pipeline.Create<String>(setup);

// execute
pipeline.Run(new String[] { "1", "2", "3", "4" });
// or
pipeline.RunAsync(new String[] { "1", "2", "3", "4" });

```
