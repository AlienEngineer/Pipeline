using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner
{

    public abstract class AsyncPipelineJob<TParam, TResult> : IPipelineJob<TParam,TResult>
    {
        public AsyncPipelineJob()
        {
            Output = new BlockingCollection<TResult>();
        }

        public BlockingCollection<TResult> Output { get; private set; }

        public void InternalPerform(TParam param)
        {
            Output.Add(Perform(param));
        }

        /// <summary>
        /// 
        /// Performs the job using the specified param.
        /// 
        /// </summary>
        /// <param name="param">The param.</param>
        /// <returns></returns>
        public abstract TResult Perform(TParam param);
    }
}
