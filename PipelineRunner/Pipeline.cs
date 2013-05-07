using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PipelineRunner
{
    public static class Pipeline
    {

        /// <summary>
        /// Creates a new Pipeline.
        /// </summary>
        /// <returns></returns>
        public static IPipeline Create()
        {
            return null;
        }

        /// <summary>
        /// Creates a new Pipeline with a Cancellation token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public static IPipeline Create(CancellationToken token)
        {
            return null;
        }

    }
}
