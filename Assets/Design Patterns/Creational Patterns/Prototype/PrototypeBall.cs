using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class PrototypeBall : MonoBehaviour, ICloneable
{
    SpriteRenderer spriteRenderer;

    private float red, green, blue;

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

    // Get references to components
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>Updated whenever Red, Green, or Blue is changed. Sets the color of the sprite. </summary>
    private void UpdateColor() {
        Color newColor = new Color(red, green, blue);
        spriteRenderer.color = newColor;
    }

    public void Clone() {

    }
}
