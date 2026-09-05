namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Constructors
    public Circle(string name, double r) : base(name) //mother constructor + proper constructor
    {
        R = r;
    }

    // Public Methods
    public override double GetArea() //calculates the area circle (mother class)
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter() //calculates the perimeter circle (mother class)
    {
       return 2 * Math.PI * R;     
    }

    // Private Methods
    private double ValidateR(double value)
    {
         if (value <= 0) // Doesn't allow negative values or 0
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }
        return value;
    }

}