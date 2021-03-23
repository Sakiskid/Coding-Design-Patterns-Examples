
using UnityEngine;
using System.Collections;
using System.Threading;
namespace DesignPatterns.Singleton {
    public class Client : MonoBehaviour
    {
        // Coroutine so we can keep retrieving the instance and adding to it
        private IEnumerator coroutine;

        void Start()
        {
            // Assign coroutine to IEnumerator method
            coroutine = GetSingletonAndAddValue(3, 3);
            StartCoroutine(coroutine);
        }

        /// <summary>Retrieves the singleton and adds to it's value.</summary>
        /// <param name="value">int: Value to add to the Singleton</param>
        /// <param name="interval">int: Interval in seconds. How often we retrieve and add to the singleton.</param>
        public static IEnumerator GetSingletonAndAddValue(int value, int interval) {
            while (true) {
                /// Notice we don't cache a reference to the Singleton ever. We can use GetInstance() every time to
                /// ...retrieve the instance and ensure there are no duplicates!
                
                // Get the instance and log it
                GUIConsole.Instance.Log($"Client: Retreiving Singleton instance: \n\t{Singleton.GetInstance()} \n\tAdding to Singleton in {interval} seconds...");
                // Wait to add the value...
                yield return new WaitForSecondsRealtime(interval);
                // Add the value to the Singleton. This is accessible everywhere!
                Singleton.AddValue(value);
            }
        }
    }
}