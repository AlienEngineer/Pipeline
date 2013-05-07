using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner.Collections
{
    class BlockingQueue<T> : IQueue<T>
    {
        private readonly BlockingCollection<T> collection = new BlockingCollection<T>();

        public void Add(T element)
        {
            collection.Add(element);
        }

        public IEnumerable<T> GetElements()
        {
            return collection.GetConsumingEnumerable();
        }
    }
}
