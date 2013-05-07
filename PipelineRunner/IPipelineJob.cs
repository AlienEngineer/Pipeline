using System;
namespace PipelineRunner
{
    interface IPipelineJob<TParam, TResult>
    {
        void InternalPerform(TParam param);
        System.Collections.Concurrent.BlockingCollection<TResult> Output { get; set; }
    }
}
