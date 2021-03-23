public interface ShapeBuilder
{
    // 1. Define point of the shape
    // 2. Size of the shape
    // 3. Add the components of the shape
    // 3a Particle system
    // 3b Rigidbody2d
    // 3c Network Object

    /// <summary>Build size and amount of points the shape has</summary>
    void BuildPoints(int numOfPoints);
    void BuildSize(float sizeInUnits);
    void BuildParticleSystem();
    void BuildRigidbody();
    void BuildNetworkListener();
    void BuildNetworkHost();
}

public class CustomShapeBuilder : ShapeBuilder {
    BuilderProduct product = new BuilderProduct();

    public void BuildPoints(int numOfPoints) {
        // GUIConsole.Instance.Log($"{this}: building shape with ");

    }

    public void BuildSize(float sizeInUnits) {

    }

    public void BuildParticleSystem() {

    }

    public void BuildRigidbody() {

    }

    public void BuildNetworkListener() {

    }

    public void BuildNetworkHost() {

    }
}

public class Director {
    public void BuildSquare () {

    }

    public void Build
}