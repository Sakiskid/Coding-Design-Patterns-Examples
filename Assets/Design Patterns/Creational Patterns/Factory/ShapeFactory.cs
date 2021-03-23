using UnityEngine;

/// <summary>Interface for all of the products of the Shape Factory.</summary>
public interface IShape {
    /// <summary>The details of the created shape</summary>
    /// <returns>Shape's details, including bounce, shape, weight, and color.</returns>
    string Details();
}

/// <summary>
/// This is the base class that will be inherited by Concrete Creators (SquareCreator), to create Concrete Products (Square).
/// </summary>
abstract class ShapeCreator
{
    /// <summary>Base method for creator, which will be overrided by sub classes (concrete creators).
    /// </summary>
    /// <returns>Object of type IShape</returns>
    protected abstract IShape FactoryMethod();

    /// <summary>Creates a new IShape shape. Call this method from the client.</summary>
    /// <returns>string result - the result of which shape was created, along with it's details.</returns>
    public string CreateShape() {
        IShape newShape = FactoryMethod();
        string result = $"ShapeCreator: Created new shape ({newShape}). \n\tShape details: {newShape.Details()}";
        return result;
    }
}

/// <summary>Concrete Creator which creates new Shape products. Create a new instance of this on the client to use it!</summary>
/// <returns>Shape products, using the CreateShape() method</returns>
class SquareCreator : ShapeCreator {
    protected override IShape FactoryMethod() {
        return new Square();
    }
}

/// <inheritdoc cref="SquareCreator"/>
class BouncyBallCreator : ShapeCreator {
    protected override IShape FactoryMethod() {
        return new BouncyBall();
    }
}