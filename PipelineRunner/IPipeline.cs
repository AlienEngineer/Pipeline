
using System.Collections.Generic;
namespace PipelineRunner
{
    public interface IPipeline<TParam>
    {

        /// <summary>
        /// Runs the pipeline with the specified params.
        /// </summary>
        /// <param name="param">The param.</param>
        void Run(IEnumerable<TParam> param);

    }
}
