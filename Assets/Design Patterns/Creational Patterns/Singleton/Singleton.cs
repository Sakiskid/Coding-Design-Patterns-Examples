namespace DesignPatterns.Singleton {
    /// <summary>
    /// Singleton that only allows a single instance to exist at any given time.
    /// <remarks>In theory, this works accross multiple threads. I wasn't able to learn and implement multi-threading in the time I had!<remarks>
    /// </summary>
    public class Singleton
    {
        // This is a static object so that all threads try to access the same _lock when using the lock conditional
        private static readonly object _lock = new object();
        // The instance of the singleton that is returned when anything tries to access it
        private static Singleton instance;
        // We are using this Value to store an int, for the purposes of testing the singleton. 
        // IMPORTANT! To access this, use instance.Value to retrieve the current instance value!
        public int Value { get; set; }

        /// <summary>Returns instance of the current singleton. Works across multiple threads.</summary>
        /// <returns>Singleton</returns>
        public static Singleton GetInstance() {

            // This conditional is required to prevent threads bypassing the lock after instance is ready
            if (instance == null) {

                // This lock only allows ONE thread to access it at a time.
                lock (_lock)
                {

                    // If there is NO instance yet
                    if (instance == null) {
                        instance = new Singleton();
                        instance.Value = 0;
                        GUIConsole.Instance.Log($"Singleton: No Singleton found, creating new Singleton instance! \n\t Instance: {instance} \n\t Starting Value: {instance.Value}");
                    }
                }
            }
            // GUIConsole.Instance.Log($"Singleton: Returning instance of singleton: \n\t " + instance);
            return instance;
        }

        /// <summary>Add value to the instance.
        /// <remarks>This method can only be accessed by the client through an instance using GetInstance().AddValue();</remarks>
        /// </summary>
        /// <param name="value">Integer to add to the current value</param>
        /// <returns>Integer value</returns>
        public static int AddValue(int value) {
            instance.Value += value;
            GUIConsole.Instance.Log($"Singleton: adding {value} to instance! Value is now: {instance.Value}.");
            return instance.Value;
        }
    }
}
