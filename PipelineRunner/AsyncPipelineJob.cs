using PipelineRunner.Collections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner
{

    public abstract class AsyncPipelineJob<TParam, TResult> : IPipelineJob
    {
        public AsyncPipelineJob()
        {
            Output = new BlockingQueue<TResult>();
        }

        public IQueue<TResult> Output { get; private set; }

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


        public void InternalPerform(object param)
        {
            InternalPerform((TParam)param);
        }

        IQueue<object> IPipelineJob<object, object>.Output
        {
            get { return (IQueue<object>)Output; }
        }
    }
}
