using PipelineRunner.Collections;
using System;

namespace PipelineRunner
{
    interface IPipelineJob<TParam, TResult>
    {
        TResult InternalPerform(TParam param);
        IQueue<TResult> Output { get; }
        Boolean PerformAsync { get; }
    }

    interface IPipelineJob : IPipelineJob<Object, Object>
    {
    }
}
