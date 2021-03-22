using UnityEngine;

/// <summary>
/// <return>
/// </summary>
public class FactoryClient : MonoBehaviour
{
    // Set reference of GUIConsole to current singleton instance
    GUIConsole guiConsole = GUIConsole.Instance; 
    // Initialize factory creators
    ShapeCreator bouncyBallCreator = new BouncyBallCreator();
    ShapeCreator squareCreator = new SquareCreator();

    public void CreateBouncyBall () {
        string result = bouncyBallCreator.CreateShape();
        guiConsole.Log(result);
    }

    public void CreateSquare () {
        string result = squareCreator.CreateShape();
        guiConsole.Log(result);
    }
}
