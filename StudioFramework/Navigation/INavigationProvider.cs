using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioFramework.Navigation
{
    public interface INavigationProvider
    {
        /// <summary>
        /// Requests the descendents for the given key. Descendents can be provided to an arbitrary depth. 
        /// </summary>
        /// <param name="key">
        /// The key to return descendents Nodes for. 
        /// An empty Enumerable may be provided to return the Nodes in the application top-level.
        /// An application may have multiple roots.
        /// </param>
        /// <returns>An Enumerable of Nodes.</returns>
        Task<IEnumerable<Node>> EnumerateNodeAsync(IEnumerable<object> key);
    }
}
