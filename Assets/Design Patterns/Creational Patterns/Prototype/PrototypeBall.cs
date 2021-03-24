using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.Prototype {
    class PrototypeBall : ICloneable
    {
        SpriteRenderer spriteRenderer;

        private float red, green, blue;
        private float mass = 1;
        private int launchForce = 50;

        // Get references to components
        private void Awake() {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Violating DRY here over these update color methods, but for the sake of this example this decreases complexity and prevents any accidental string inputs

        /// <summary>Update the color of the PrototypeBall that is to be cloned.</summary>
        /// <param name="slider">Which Unity Slider will control this color?</param>
        public void UpdateRedColor(Slider slider) {
            red = slider.value;
            UpdateColor();
        }

        /// <inheritdoc cref="UpdateRedColor" />
        public void UpdateBlueColor(Slider slider) {
            blue = slider.value;
            UpdateColor();
        }

        /// <inheritdoc cref="UpdateRedColor" />
        public void UpdateGreenColor(Slider slider) {
            green = slider.value;
            UpdateColor();
        }

        /// <summary>Update the Mass of the PrototypeBall that is to be cloned.</summary>
        /// <param name="slider">Which Unity Slider will control the mass of this object?</param>
        public void UpdateMass(Slider slider) {
            mass = slider.value;
        }

        /// <summary>Updated whenever Red, Green, or Blue is changed. Sets the color of the sprite. </summary>
        private void UpdateColor() {
            Color newColor = new Color(red, green, blue);
            spriteRenderer.color = newColor;
        }

        /// <summary>Clones the PrototypeBall</summary>
        protected override void ShallowCopy() {
            /* It is my understanding that in Unity C#, there are built in prototype methods (C# has MemberwiseClone, Unity has Instantiation). 
            The following method clones them in a purposefully bulkier way for the purpose of this exercise. 
            However, MemberwiseClone and the 'new' keyword can't be used on Monobehaviour (and MonoBehaviour is needed because this is a Unity gameObject). So we will use Instantiation here.
            
            === What the bulky method would look like
            PrototypeBall newBall = PrototypeBall;
            newBall.red = red;
            newBall.green = green;
            newBall.blue = blue;
            return newBall;

            === What memberwise would look like
            return this.MemberwiseClone()
            */

            // Cloning using Instantiation:
            GameObject newBall = Instantiate(this.gameObject, gameObject.transform.position, Quaternion.identity);

            // Turning it into a physical object
            Rigidbody2D newBallRb2d = newBall.GetComponent<Rigidbody2D>();
            newBallRb2d.simulated = true;
            newBallRb2d.AddForce(Vector2.right * launchForce);
            newBallRb2d.mass = mass;
        }
    }
}