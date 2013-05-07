using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner
{

    class PipelineJob<TParam, TResult> : PipelineRunner.IPipelineJob<TParam,TResult>
    {
        public BlockingCollection<TResult> Output { get; set; }

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
