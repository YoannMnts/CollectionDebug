namespace CollectionDebugger.Core
{
    internal class SnapshotWatch : CollectionWatchBase
    {
        private readonly WatchEntry[] snapshot;
        public readonly string timestamp;
        public readonly string guid;

        public SnapshotWatch(string label, WatchEntry[] snapshot) : base(label)
        {
            this.snapshot = snapshot;
            timestamp = System.DateTime.Now.ToString("HH:mm:ss");
            guid = System.Guid.NewGuid().ToString();
        }

        protected override int GetCount() => snapshot.Length;
        protected override void FillEntries(WatchEntry[] entries)
            => System.Array.Copy(snapshot, entries, snapshot.Length);
    }
}