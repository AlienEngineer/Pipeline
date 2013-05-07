using System;
using System.Collections.Concurrent;
namespace PipelineRunner
{
    interface IPipelineJob<TParam, TResult>
    {
        void InternalPerform(TParam param);
        BlockingCollection<TResult> Output { get; }
    }
}
