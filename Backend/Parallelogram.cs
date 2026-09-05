namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle // Herency from Rectangle
{
      // Fields
    private double _h;

      // Properties
    public double H
    {
        get => _h; 
        set => _h = ValidateH(value); 
    }

     // Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name,a,b) //calls the constructor of the mother class
    {
        H = h;
    }

    // Public Methods

    public override double GetArea() // Calculates the area
    {
        return B * H;
    }

     public override double GetPerimeter() //calculates the perimeter 
    {
        return 2 * (A + B);
    }

      //Private Methods
    private double ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }
}