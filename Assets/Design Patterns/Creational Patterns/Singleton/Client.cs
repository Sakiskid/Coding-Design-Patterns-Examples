
using UnityEngine;
using System.Collections;
using System.Threading;
namespace DesignPatterns.Singleton {
    public class Client : MonoBehaviour
    {
        private IEnumerator coroutine;

        void Start()
        {
            // Assign coroutine to IEnumerator method
            coroutine = GetSingletonAndAddValue(3, 3);
            StartCoroutine(coroutine);
        }

        public static IEnumerator GetSingletonAndAddValue(int value, int interval) {
            while (true) {
                GUIConsole.Instance.Log($"Client: Retreiving Singleton instance: \n\t{Singleton.GetInstance()} \n\tAdding to Singleton in {interval} seconds...");
                yield return new WaitForSecondsRealtime(interval);
                Singleton.AddValue(value);
            }
        }
    }
}