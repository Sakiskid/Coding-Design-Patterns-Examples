using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.Builder {
    public class BuilderClient : MonoBehaviour
    {
        [SerializeField] Slider sizeSlider;

        Director director = new Director();
        CustomShapeBuilder builder = new CustomShapeBuilder();

        private void Awake () {
            // Ensure reference is assigned
            if (!sizeSlider) { Debug.LogError("BuilderClient: sizeSlider reference not set", this.gameObject); }
            // This can be placed inside the individual methods if we have different builders, but for now, in the Awake suits our needs just fine
            director.ChangeBuilder(builder);
        }

        public void BuildStopsign () {
            director.BuildStopsign(Mathf.RoundToInt(sizeSlider.value));
            builder.GetProduct().ListDetails();
        }

        public void BuildCrate () {
            director.BuildCrate(Mathf.RoundToInt(sizeSlider.value));
            builder.GetProduct().ListDetails();
        }
    }
    // 
}