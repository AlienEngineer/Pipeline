﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner.Collections
{
    /// <summary>
    /// Represents a queue of elements
    /// </summary>
    /// <typeparam name="T">element type</typeparam>
    interface IQueue<T>
    {

        /// <summary>
        /// Adds the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        void Add(T element);

        /// <summary>
        /// Gets the elements.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetElements();

    }
}
