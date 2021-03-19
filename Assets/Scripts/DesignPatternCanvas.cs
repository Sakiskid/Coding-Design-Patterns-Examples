using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignPatternCanvas : MonoBehaviour
{
    // Required ScriptableObject with respective design pattern data
    [SerializeField] private DesignPatternDataSO designPatternData;

    // Internal Prefab References
    [SerializeField] Text titleText;


    private void Awake() {
        CheckForNullReference();
        UpdateText();
    }

    private void CheckForNullReference () {
        // Log the error message and show which gameObject needs the reference
        if (designPatternData == null) { Debug.LogError("Missing required DesignPatternDataSO reference in " + this.gameObject, this.gameObject); }
    }

    private void UpdateText() {
        titleText.text = designPatternData.Title;
    }
}
