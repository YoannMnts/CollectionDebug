using System.Collections.Generic;

namespace CollectionDebugger.Core
{
    internal interface ICollectionWatch
    {
        string Label { get; }
        IEnumerable<WatchEntry> GetEntries();
    }
}