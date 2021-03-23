namespace DesignPatterns.Builder {
    public interface IShapeBuilder {
        // 1. Define point of the shape
        // 2. Size of the shape
        // 3. Material and mass

        /// <summary>Build size and amount of points the shape has</summary>
        void BuildName(string name);
        void BuildPoints(int numOfPoints);
        void BuildSize(float sizeInUnits);
        void BuildMaterial(string material, float mass);
    }

    public class CustomShapeBuilder : IShapeBuilder {
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

        public Shape GetProduct () {
            return product;
        }

        private void Reset () {
            product = new Shape();
        }   
    }

    public class Director {
        public IShapeBuilder Builder { get; set; }

        public void ChangeBuilder (IShapeBuilder builder) {
            Builder = builder;
        }

        public void BuildCrate (int sizeInUnits) {
            Builder.BuildName("Crate");
            Builder.BuildPoints(4);
            Builder.BuildSize(sizeInUnits);
            Builder.BuildMaterial("Wood", 5);
        }

        public void BuildStopsign (int sizeInUnits) {
            Builder.BuildName("Stop Sign");
            Builder.BuildPoints(8);
            Builder.BuildSize(sizeInUnits);
            Builder.BuildMaterial("Metal", 2);
        }
    }
}