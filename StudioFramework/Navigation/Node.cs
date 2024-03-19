using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioFramework.Navigation
{
    /// <summary>
    /// Constructs a new Node record, representing a Node in the application's navigation hierarchy.
    /// </summary>
    /// <param name="Key">The key object uniquely representing this Node.</param>
    /// <param name="Title">The title for this Node, displayed to the user.</param>
    /// <param name="Descendents"></param>
    /// <param name="Enumerated"></param>
    public record Node(
        object Key,
        string Title,
        object[] Descendents,
        bool Enumerated
        );
}
