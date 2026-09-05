namespace GeometricFigures.Backend;

public class Square : GeometricFigure // Square is a doughter class, GeometricFigure is the mother class or base classs. Start a herency
{
    // Fields
    private double _a;

    // Properties
    public double A
    {
        get => _a; 
        set => _a = ValidateA(value); 
    }

    // Constructors

    public Square(string name, double a) : base(name) //calls the constructor of the mother class
    {
        A = a;
    }

    //Public methods
    public override double GetArea() //calculates the area (mother class)
    {
        return A * A;
    }

    public override double GetPerimeter() //calculates the perimeter (mother class)
    {
        return 4 * A;
    }


    // Private Methods
    private double ValidateA(double value)
    {
        if (value <= 0) // Doesn't allow negative values or 0
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The value: {value} is not valid.");
        }
        return value;
        
    }
}