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

    /// <summary>
    /// Log text to the GUI Console to be visualized for the user
    /// </summary>
    /// <param name="text">The text to be displayed in the GUIConsole</param>
    public void Log(string text) {
        // New Line for each log
        text += "\n";
        // Insert text to be logged
        consoleText = consoleText.Insert(0, text);
        // Insert timestamp and trim it down
        consoleText = consoleText.Insert(0, "Time: " + Time.timeAsDouble.ToString().Remove(4) + "\n ");
        UpdateGUI();
    }

    private void UpdateGUI() {
        textObject.text = consoleText;
    }
}