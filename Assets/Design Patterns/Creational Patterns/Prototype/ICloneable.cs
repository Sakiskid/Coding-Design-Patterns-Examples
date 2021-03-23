using UnityEngine;

abstract class ICloneable : MonoBehaviour {
    /// <summary>The ShallowCopy() method is meant to be overridden for each ICloneable object.</summary>
    protected abstract void ShallowCopy ();

    /// <summary>The clientside method that is called to clone an ICloneable object.</summary>
    public void Clone() {
        GUIConsole.Instance.Log($"Cloning gameObject: {this.gameObject}");
        ShallowCopy();
    }
}