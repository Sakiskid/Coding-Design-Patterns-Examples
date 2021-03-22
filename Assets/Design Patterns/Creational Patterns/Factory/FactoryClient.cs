using UnityEngine;

/// <summary>
/// <return>
/// </summary>
public class FactoryClient : MonoBehaviour
{
    ShapeCreator bouncyBallCreator = new BouncyBallCreator();
    ShapeCreator squareCreator = new SquareCreator();

    public void CreateBouncyBall () {
        bouncyBallCreator.CreateShape();
    }

    public void CreateSquare () {
        squareCreator.CreateShape();
    }
}
