namespace GeometricFigures.Backend;

public class Rectangle : Square //herency from square
{
    // Fields
    private double _b;

      // Properties
    public double B
    {
        get => _b; 
        set => _b = ValidateB(value); 
    }

    // Constructors
    public Rectangle(string name, double a, double b) : base(name,a) //calls the constructor of the mother class
    {
        B = b;
    }

    // Public Methods

    public override double GetArea() // Calculates the area
    {
        return A * B;
    }

     public override double GetPerimeter() //calculates the perimeter 
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