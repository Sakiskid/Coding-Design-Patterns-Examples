using UnityEngine;

namespace DesignPatterns.Factory {
    /// <summary> The client-side factory that initializes the Concrete Creators and handles client-side creation.
    /// <remarks> All of the creation of objects should be accessed here, not through the ShapeFactory </remarks>
    /// </summary>
    public class FactoryClient : MonoBehaviour
    {
        // Initialize factory concrete creators
        ShapeCreator bouncyBallCreator = new BouncyBallCreator();
        ShapeCreator squareCreator = new SquareCreator();

        /// <summary>
        /// Create BouncyBall using Concrete Creators
        /// </summary>
        public void CreateBouncyBall () {
            string result = bouncyBallCreator.CreateShape();
            GUIConsole.Instance.Log(result);
        }

        /// <summary>
        /// Create Square using Concrete Creators
        /// </summary>
        public void CreateSquare () {
            string result = squareCreator.CreateShape();
            GUIConsole.Instance.Log(result);
        }
    }
}