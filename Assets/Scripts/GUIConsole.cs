using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// GUI Console that receives and logs event for user visualization.
/// </summary>
public class GUIConsole : MonoBehaviour
{
    [SerializeField] private Text textObject;
    private string consoleText = "";

    // Singleton fields and properties
    private static GUIConsole instance;
    public static GUIConsole Instance { get { return instance; } }
    
    private void Awake() {
        // Singleton pattern for GUIConsole
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }

        // Ensure textObject reference is set
        if (!textObject) { Debug.LogError("GUI Console :: textObject reference not set!", this.gameObject); }
    }

    public void Log(string text) {
        Debug.Log("GUIConsole: inserting text at 0 and updating gui");
        consoleText.Insert(0, text);
        UpdateGUI();
    }

    private void UpdateGUI() {
        textObject.text = consoleText;
    }
}
