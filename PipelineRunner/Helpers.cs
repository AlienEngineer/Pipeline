using PipelineRunner.Collections;
using PipelineRunner.Stages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner
{
    internal static class Helpers
    {

        public static IEnumerable<IPipelineJob> ToEnumerable<TParam, TResult>(this StageSetup<TParam, TResult> stageSetup)
        {
            var current = stageSetup.Current.First;

            while (current != null)
            {
                yield return current.Job;
                current = current.Next;
            }
        }

        public static IQueue<Object> ToQueue<T>(this IEnumerable<T> source)
        {
            var queue = new PipelineRunner.Collections.BlockingQueue<Object>();

            foreach (var item in source)
            {
                queue.Add(item);
            }

            queue.CompleteAdding();

            return queue;
        }

    }
}
