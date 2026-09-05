namespace GeometricFigures.Backend;

public class Kite : Rhombus//All herency from its mother Rhombus
{
    // Fields
    private double _b;

    // Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    //Constructors
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)//herency of its mother Rhombus class
    {
        B = b;
    }

    // Public Methods
    public override double GetArea() // Calculates the area. Herency of Rhombus mother
    {
        return D1 * D2 / 2;
    }

    public override double GetPerimeter() // Calculates the perimeter
    {
        return 2 * (A + B);
    }

    //Private Methods
    private double ValidateB(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }

}

