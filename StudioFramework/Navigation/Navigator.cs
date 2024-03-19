using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioFramework.Navigation
{
    public class Navigator(IEnumerable<INavigationProvider> providers) : NotifiesPropertyChanged
    {
        private readonly IEnumerable<INavigationProvider> _providers = providers;

        /// <summary>
        /// Navigate the application to the specified hierarchy node.
        /// </summary>
        /// <param name="key">The key of the hierarchy node to navigate to.</param>
        /// <returns>A Task completing once the navigation action is complete.</returns>
        public async Task NavigateAsync(IEnumerable<object> key)
        {
            throw new NotImplementedException();
        }

        private Node? _currentNode = null;
        /// <summary>
        /// The Node this Navigator is currently navigated to.
        /// </summary>
        public Node? CurrentNode { 
            get => _currentNode;
            private set => SetField(out _currentNode, value);
        }

        /// <summary>
        /// Internal hash set containing the keys of all nodes in the Nodes collection.
        /// </summary>
        private HashSet<object[]> _nodeKeys = [];

        private ObservableCollection<Node> _nodes = [];
        /// <summary>
        /// An ObservableCollection of all the Nodes this Navigator has enumerated so far.
        /// This collection may be completely replaced by the relevant <see cref="INotifyPropertyChanged.PropertyChanged"/> event.
        /// </summary>
        public ObservableCollection<Node> Nodes
        {
            get => _nodes;
            private set => SetField(out _nodes, value);
        }
    }
}
