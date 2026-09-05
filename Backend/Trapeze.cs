namespace GeometricFigures.Backend;

public class Trapeze : Triangle // Inherits from Triangle
{
    // Fields
    private double _d;
    

      // Properties
    public double D
    {
        get => _d; 
        set => _d = ValidateD(value); 
    }


      // Constructors
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h) // Calls the constructor of the mother class Triangle
{
    D = d;
}


    // Public Methods

    public override double GetArea() // Calculates the area
    {
        return (B + D) * H / 2;
    }

     public override double GetPerimeter() //calculates the perimeter 
    {
        return A + B + C + D;
    }

      //Private Methods
    private double ValidateD(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }

        return value;
    }

}