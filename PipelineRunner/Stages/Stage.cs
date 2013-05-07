
using System.Collections.Generic;
namespace PipelineRunner.Stages
{
    class Stage : IStage
    {
        public Stage(IPipelineJob job)
        {
            Job = job;
        }

        public IPipelineJob Job { get; private set; }

        public IStage Next { get; set; }

        public IStage First { get; set; }

    }


    public static class Config
    {
        public static StageSetup<TParam, TResult> Stage<TParam, TResult>(AsyncJob<TParam, TResult> job)
        {
            return new StageSetup<TParam, TResult>(new Stage(job));
        }
    }

}
