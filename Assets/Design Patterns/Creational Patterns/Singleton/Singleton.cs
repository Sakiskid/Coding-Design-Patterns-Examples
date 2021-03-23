namespace DesignPatterns.Singleton {
    public class Singleton
    {
        private static readonly object _lock = new object();
        private static Singleton instance;
        // We are using this Value to store an int, for the purposes of testing the singleton
        public int Value { get; set; }

        public static Singleton GetInstance(int value) {
            if (instance == null) {
                // This lock only allows ONE thread to access it at a time.
                lock (_lock)
                {
                    if (instance == null) {
                        instance = new Singleton();
                        instance.Value = value;
                    }
                }
            }
            return instance;
        }
    }
}
