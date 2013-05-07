Pipeline
========

C# implementation of a generic pipeline.


```C#

// create
var pipeline = Pipeline.Create();

// setup
pipeline
  .AddJob(job1)
  .AddJob(job2)
  .AddJob(job3)
  .AddJob(job4);

// execute
pipeline.Run();
// or
pipeline.RunAsync();

```
