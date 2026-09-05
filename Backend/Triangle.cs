namespace GeometricFigures.Backend;

public class Triangle : Rectangle // Inherits from Rectangle
{
    // Fields
    private double _c;
    private double _h;

      // Properties
    public double C
    {
        get => _c; 
        set => _c = ValidateC(value); 
    }

     public double H
    {
        get => _h; 
        set => _h = ValidateH(value); 
    }

      // Constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b) //calls the constructor of the mother class Rectangle
    {
        C = c;
        H = h;
    }

    // Public Methods

    public override double GetArea() // Calculates the area
    {
        return (B * H) / 2;
    }

     public override double GetPerimeter() //calculates the perimeter 
    {
        return A + B + C;
    }

      //Private Methods
    private double ValidateC(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }

      private double ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }
}