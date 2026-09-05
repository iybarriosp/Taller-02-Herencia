namespace GeometricFigures.Backend;

public abstract class GeometricFigure //Base class for all gigures
{

    //Fields

    
    //Properties

    public string Name //figure name
    { 
        get; 
        set; 
    }

    //Constructors
    public GeometricFigure(string name)
    {
        Name = name;
    }

   
    // Public Methods

    public abstract double GetArea(); //every figure has an area, but each figure calculates it differently

    public abstract double GetPerimeter(); // every figure has a perimeter, but each figure calculates it differently

    public override string ToString() // To show the line in console the good way
    {
        return $"{Name,-13} => Area.....: {GetArea(),15:N5} Perimeter: {GetPerimeter(),15:F5}";//F formate decimal number, {Name,-13} aline -13 spaces to left
    }


}
