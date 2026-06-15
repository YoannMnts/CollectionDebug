using System.Collections.Generic;
namespace CollectionDebugger.Core
{
    public static class CollectionDebug
    {
        //si le add peux ajouter plusieurs fois le meme type utiliser le Curious Generic Pattern
        private static readonly Dictionary<string, ICollectionWatch> Watches;

        public static void Watch<T>(string label, IEnumerable<T> collection)
            => Watches.Add(label, new ListWatch<T>(label, collection));

        public static void Watch<TKey, TValue>(string label, IDictionary<TKey, TValue> dict)
        {
        }

        public static void Unwatch(string label)
        {
        }

        public static void UnwatchAll()
        {
        }

        internal static IReadOnlyDictionary<string, ICollectionWatch> GetWatches() => Watches;
    }
}