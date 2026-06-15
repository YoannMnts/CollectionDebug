using System.Collections.Generic;
using UnityEngine.Pool;

namespace CollectionDebugger.Core
{
    internal class ListWatch<T> : ICollectionWatch
    {
        public ListWatch(string label, IEnumerable<T> collection)
        {
            Label = label;
            this.collection = collection;
        }

        private readonly IEnumerable<T> collection;

        public string Label { get; private set; }
        
        //TODO refacto to make less allocation
        public IEnumerable<WatchEntry> GetEntries()
        {
            using (ListPool<WatchEntry>.Get(out var list))
            {
                int index = 0;
                foreach (var item in collection)
                {
                    list.Add(new WatchEntry(index, item));
                    index++;
                }
                return list.ToArray();
            }
        }
    }
}