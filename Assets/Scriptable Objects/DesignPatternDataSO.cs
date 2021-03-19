using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Design Pattern Data", order = 1)]
public class DesignPatternDataSO : ScriptableObject
{
    // Scriptable Object for holding data for each Design Pattern
    [SerializeField] private string title, shortDescription;
     
    public string GetTitle () {
        return title;
    }

    public string GetShortDescription () {
        return shortDescription;
    }
}
