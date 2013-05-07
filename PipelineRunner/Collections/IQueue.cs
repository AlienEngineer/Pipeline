using System.Collections.Generic;

namespace PipelineRunner.Collections
{
    /// <summary>
    /// Represents a queue of elements
    /// </summary>
    /// <typeparam name="T">element type</typeparam>
    public interface IQueue<T>
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

        /// <summary>
        /// Gets the element count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        int Count { get; }


        /// <summary>
        /// Completes the adding.
        /// </summary>
        void CompleteAdding();
    }
}
