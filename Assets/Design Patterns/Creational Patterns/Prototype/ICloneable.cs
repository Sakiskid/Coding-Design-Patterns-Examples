using UnityEngine;

abstract class ICloneable : MonoBehaviour{
    // The ShallowCopy() method is meant to be overridden for each ICloneable object.
    protected abstract ICloneable ShallowCopy ();

    /// <summary>The clientside method  </summary>
    public void Clone() {
        ICloneable copy = ShallowCopy();
        GUIConsole.Instance.Log($"Cloning gameObject: {copy}");
        
         // Instantiating just so we can produce a physical unity gameObject. This isn't required to clone the actual C# object.
        Instantiate(copy, gameObject.transform.position, Quaternion.identity);
    }
}