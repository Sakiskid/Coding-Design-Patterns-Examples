using UnityEngine;

/// <summary>
/// <return>
/// </summary>
public class FactoryClient : MonoBehaviour
{
    // Initialize factory creators
    ShapeCreator bouncyBallCreator = new BouncyBallCreator();
    ShapeCreator squareCreator = new SquareCreator();

    public void CreateBouncyBall () {
        Debug.Log("debug creating: " + bouncyBallCreator.CreateShape());
        GUIConsole.Instance.Log(bouncyBallCreator.CreateShape());
    }

    public void CreateSquare () {
        squareCreator.CreateShape();
    }
}
