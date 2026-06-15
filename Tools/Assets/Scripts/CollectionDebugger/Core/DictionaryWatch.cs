using System.Collections.Generic;
using UnityEngine.Pool;

namespace CollectionDebugger.Core
{
    internal class DictionaryWatch<TKey, TValue> : ICollectionWatch
    {
        public DictionaryWatch(string label, IDictionary<TKey, TValue> collection)
        {
            Label = label;
            this.collection = collection;
        }
        
        private readonly IDictionary<TKey, TValue> collection;
        
        public string Label { get; private set; }
        
        //TODO refacto to make less allocation
        public IEnumerable<WatchEntry> GetEntries()
        {
            using (ListPool<WatchEntry>.Get(out var list))
            {
                foreach (var (key, value) in collection)
                {
                    list.Add(new WatchEntry(key, value));
                }
                return list.ToArray();
            }
        }
    }
}