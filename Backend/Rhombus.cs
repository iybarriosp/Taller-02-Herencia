namespace GeometricFigures.Backend;

public class Rhombus : Square //Herency of its mother Square
{
  // Fields
    private double _d1;
    private double _d2;  

  // Properties
    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }
    
    // Constructors

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)//herency of its mother square class
    {
        D1 = d1;
        D2 = d2;
    }

    // Public Methods
    public override double GetArea() // Calculates the area. Herency of Square mother
    {
        return D1 * D2 / 2;
    }

    public override double GetPerimeter() //calculates the perimeter (mother square)
    {
        return 4 * A;
    }

    // Private Methods

    private double ValidateD1(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }

     private double ValidateD2(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }
}