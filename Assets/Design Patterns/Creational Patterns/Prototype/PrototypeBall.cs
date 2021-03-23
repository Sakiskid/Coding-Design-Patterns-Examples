using UnityEngine;
using UnityEngine.UI;

class PrototypeBall : ICloneable
{
    SpriteRenderer spriteRenderer;

    private float red, green, blue, mass;
    private int launchForce = 5;

    // Violating DRY here over these update color methods, but for the sake of this example this decreases complexity and prevents any accidental string inputs

    public void UpdateRedColor(Slider slider) {
        red = slider.value;
        UpdateColor();
    }

    public void UpdateBlueColor(Slider slider) {
        blue = slider.value;
        UpdateColor();
    }

    public void UpdateGreenColor(Slider slider) {
        green = slider.value;
        UpdateColor();
    }

    public void UpdateMass(Slider slider) {
        mass = slider.value;
    }

    // Get references to components
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>Updated whenever Red, Green, or Blue is changed. Sets the color of the sprite. </summary>
    private void UpdateColor() {
        Color newColor = new Color(red, green, blue);
        spriteRenderer.color = newColor;
    }

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
        Rigidbody2D newBallRb2d = newBall.GetComponent<Rigidbody2D>();
        newBallRb2d.simulated = true;
        newBallRb2d.AddForce(Vector2.right * launchForce);
        newBallRb2d.mass = mass;
    }
}
