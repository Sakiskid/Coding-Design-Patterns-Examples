namespace DesignPatterns.Builder {
    public interface IShapeBuilder {
        /// <summary>Name of the shape being built</summary>
        /// <param name="name">Name of the shape</param>
        void BuildName(string name);
        /// <summary>Number of points this shape has (eg: 4 points is a square)</summary>
        /// <param name="numOfPoints">Number of points, or corners, on the shape</param>
        void BuildPoints(int numOfPoints);
        /// <summary>Size of the shape in Unity units</summary>
        /// <param name="sizeInUnits">Size of the shape in Unity Units</param>
        void BuildSize(float sizeInUnits);
        /// <summary>Material the shape is made out of, and the mass of the shape</summary>
        /// <param name="material">Physical material the shape is made out of</param>
        /// <param name="mass">The mass of the shape's object</param>
        void BuildMaterial(string material, float mass);
    }

    /// <summary>
    /// This is a "Builder" class which builds a custom shape. Controlled by the director, unless the client wants a custom order.
    /// </summary>
    public class CustomShapeBuilder : IShapeBuilder {
        // The shape to be built
        Shape product = new Shape();

        public void BuildName(string name) {
            product.Name = name;
        }

        public void BuildPoints(int numOfPoints) {
            product.Points = numOfPoints;
        }

        public void BuildSize(float sizeInUnits) {
            product.Size = sizeInUnits;
        }

        public void BuildMaterial(string material, float mass) {
            product.Material = material;
            product.Mass = mass;
        }   

        /// <summary>Returns the product being created by the Builder</summary>
        public Shape GetProduct () {
            return product;
        }

        /// <summary>Resets the builder to ready itself for another new shape</summary>
        private void Reset () {
            product = new Shape();
        }   
    }

    /// <summary>
    /// The Director sends common orders to the Builders, and provides an easy way for the client to place orders.
    /// </summary>
    public class Director {
        // Property to get/set the current builder
        public IShapeBuilder CurBuilder { get; set; }

        public void ChangeBuilder (IShapeBuilder builder) {
            CurBuilder = builder;
        }

        /// <summary>
        /// Tell the Director to start a project for a "Crate" build!
        /// </summary>
        /// <param name="sizeInUnits">Size of the Crate in Unity units</param>
        public void BuildCrate (int sizeInUnits) {
            // This whole method is pretty crate.
            CurBuilder.BuildName("Crate");
            CurBuilder.BuildPoints(4);
            CurBuilder.BuildSize(sizeInUnits);
            CurBuilder.BuildMaterial("Wood", 5);
        }

        /// <summary>
        /// Tell the Director to start a project for a "Stopsign" build!
        /// </summary>
        /// <param name="sizeInUnits">Size of the stopsign in Unity units</param>
        public void BuildStopsign (int sizeInUnits) {
            CurBuilder.BuildName("Stop Sign");
            CurBuilder.BuildPoints(8);
            CurBuilder.BuildSize(sizeInUnits);
            CurBuilder.BuildMaterial("Metal", 2);
        }
    }
}