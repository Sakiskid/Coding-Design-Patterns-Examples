namespace DesignPatterns.Builder {
    public interface IBuilderProduct {
        /// <summary>Name of the shape</summary>
        string Name { get; set; }
        /// <summary># of Points, or corners, on the shape</summary>
        int Points { get; set; }
        /// <summary>Size of the Shape in units</summary>
        float Size { get; set; }
        /// <summary>Physical material of the shape</summary>
        string Material { get; set; }
        /// <summary>Mass of the shape</summary>
        float Mass { get; set; }

        /// <summary>Print the Shape's details to the GUIConsole.</summary>
        void ListDetails();
    }

    /// <summary>
    /// "Product" of a builder. This is what is returned to the client for use.
    /// </summary>
    public class Shape : IBuilderProduct {
        public string Name { get; set;}
        public int Points { get; set; }
        public float Size { get; set; }
        public string Material { get; set; }
        public float Mass { get; set; }

        public void ListDetails () {
            GUIConsole.Instance.Log($"Product: {Name} \n\t Points: {Points} \n\t Size: {Size} \n\t Material: {Material} \n\t Mass: {Mass}");
        }
    }
}