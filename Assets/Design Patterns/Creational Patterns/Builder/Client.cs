using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.Builder {
    /// <summary>
    /// Client-size Monobehaviour class that lets the user send orders to the Build Director.
    /// </summary>
    public class Client : MonoBehaviour
    {
        /// <summary>The slider that controls the size in units of the shape to be built.</summary>
        [SerializeField] Slider sizeSlider;
        
        // Director that controls the build projects. Only one director is needed to save the most used builds for reuse.
        Director director = new Director();

        /// We can have multiple builders here, but we need to declare a Concrete Builder (like CustomShapeBuilder), and not the Builder interface.
        /// For this excercise, a single builder would be fine. 
        /// But if we wanted to take these 2D shapes, and turn them into 3D shapes and elongate them using a custom algorithm, we could use 
        /// ...another builder that holds those algorithms and methods there, and turns our 2D shape build order into a 3D shape product.
        CustomShapeBuilder builder = new CustomShapeBuilder();

        private void Awake () {
            // Ensure reference is assigned
            if (!sizeSlider) { Debug.LogError("BuilderClient: sizeSlider reference not set", this.gameObject); }
            // This can be placed inside the individual methods if we have different builders, but for now, in the Awake suits our needs just fine
            director.ChangeBuilder(builder);
        }

        public void BuildStopsign () {
            // Tell the director to start a stopsign build
            director.BuildStopsign(Mathf.RoundToInt(sizeSlider.value));
            // Then, get the product from the builder and list the details in the GUIConsole
            builder.GetProduct().ListDetails();
        }

        public void BuildCrate () {
            director.BuildCrate(Mathf.RoundToInt(sizeSlider.value));
            builder.GetProduct().ListDetails();
        }
    }
    // 
}