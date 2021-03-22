using UnityEngine;

// Interface for all products of the Factory
public interface IShape {
    string Details();
}

abstract class ShapeCreator
{
    // Base method for creator, which will be overrided by sub classes (concrete creators)
    public abstract IShape FactoryMethod();

    public string CreateShape() {
        IShape newShape = FactoryMethod();
        string result = $"ShapeCreator :: Created new shape ({newShape}). Shape details: {newShape.Details()}";
        return result;
    }
}

class SquareCreator : ShapeCreator {
    public override IShape FactoryMethod() {
        return new Square();
    }
}

class BouncyBallCreator : ShapeCreator {
    public override IShape FactoryMethod() {
        return new BouncyBall();
    }
}