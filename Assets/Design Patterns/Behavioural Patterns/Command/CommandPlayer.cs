using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the "Player". In the command pattern, this is known as the invoker.
/// </summary>
public class CommandPlayer : MonoBehaviour
{
    [SerializeField] private string playerName = "Tyler";

    public string GetPlayerName () {
        return playerName;
    }
}
