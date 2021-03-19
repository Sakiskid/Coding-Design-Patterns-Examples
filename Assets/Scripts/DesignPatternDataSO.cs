using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Design Pattern Data", order = 1)]
public class DesignPatternDataSO : ScriptableObject
{
    // Scriptable Object for holding data for each Design Pattern
    // Fields are still serialized for editor initialization
    [SerializeField] private string title, shortDescription;
     
    //  Title is a basic property for getting and setting the 'title' field.
    public string Title { 
        get { return title; }
        set { title = value; }
    }

    public string GetShortDescription () {
        return shortDescription;
    }
}
