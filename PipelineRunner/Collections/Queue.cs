﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner.Collections
{
    class Queue<T> : IQueue<T>
    {
        private readonly LinkedList<T> collection = new LinkedList<T>();

        public void Add(T element)
        {
            collection.AddLast(element);
        }

        public IEnumerable<T> GetElements()
        {
            var element = collection.First;
            while (element != null)
            {
                collection.RemoveFirst();
                yield return element.Value;
                element = collection.First;
            }
        }
    }
}
