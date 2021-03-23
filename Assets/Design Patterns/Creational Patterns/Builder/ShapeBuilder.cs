public interface ShapeBuilder {
    // 1. Define point of the shape
    // 2. Size of the shape
    // 3. Material and mass

    /// <summary>Build size and amount of points the shape has</summary>
    void BuildPoints(int numOfPoints);
    void BuildSize(float sizeInUnits);
    void BuildMaterial(string material, float mass);
}

public class CustomShapeBuilder : ShapeBuilder {
    BuilderProduct product = new BuilderProduct();

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

    public BuilderProduct GetProduct () {
        return product;
    }

    private void Reset () {
        product = new BuilderProduct();
    }
}

public class Director {
    private CustomShapeBuilder builder;

    public void BuildCrate (int sizeInUnits) {

        builder.BuildPoints(4);
        builder.BuildSize(sizeInUnits);
        builder.BuildMaterial("Wood", 5);
    }

    public void BuildStopsign (int sizeInUnits) {
        builder.BuildPoints(8);
        builder.BuildSize(sizeInUnits);
        builder.BuildMaterial("Metal", 2);
    }
}