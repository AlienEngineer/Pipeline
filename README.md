Pipeline
========

C# implementation of a generic pipeline.


```C#
var pipeline = Pipeline.Create();
pipeline.AddJob(job1);
pipeline.AddJob(job2);
pipeline.AddJob(job3);
pipeline.AddJob(job4);

pipeline.Run();
```
