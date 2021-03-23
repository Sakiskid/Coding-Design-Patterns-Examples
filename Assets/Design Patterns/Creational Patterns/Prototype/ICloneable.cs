using UnityEngine;

abstract class ICloneable : MonoBehaviour {
    // The ShallowCopy() method is meant to be overridden for each ICloneable object.
    protected abstract void ShallowCopy ();

    /// <summary>The clientside method  </summary>
    public void Clone() {
        GUIConsole.Instance.Log($"Cloning gameObject: {this.gameObject}");
        ShallowCopy();
    }
}