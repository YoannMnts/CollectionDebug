namespace CollectionDebugger.Core
{
    internal readonly struct WatchEntry
    {
        public WatchEntry(object key, object value)
        {
            Key = key;
            Value = value;
        }
        
        public readonly object Key;   
        public readonly object Value; 
    }
}