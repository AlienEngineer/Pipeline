Pipeline
========

C# implementation of a generic pipeline.


```C#

// create
var pipeline = Pipeline.Create();

// setup
pipeline.AddJob(job1);
pipeline.AddJob(job2);
pipeline.AddJob(job3);
pipeline.AddJob(job4);

// execute
pipeline.Run();
pipeline.RunAsync();


```
