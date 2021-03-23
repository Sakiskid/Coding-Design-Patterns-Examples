using UnityEngine;
namespace DesignPatterns.Singleton {
    public class Client : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Singleton.GetInstance(5);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}