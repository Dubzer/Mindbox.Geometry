namespace Mindbox.Geometry;

/// <summary>
/// Class that represents a triangle
/// </summary>
public class Triangle : Figure
{
    public readonly double X;
    public readonly double Y;
    public readonly double Z;

    /// <summary>
    /// Constructor by the sides of the triangle
    /// </summary>
    /// <exception cref="ArgumentException">Will be thrown if condition on the sides of the triangle does not pass</exception>
    public Triangle(double x, double y, double z)
    {
        // See: https://en.wikipedia.org/wiki/Triangle#Condition_on_the_sides
        if (x + y <= z || x + z <= y || z + y <= x)
            throw new ArgumentException("Sum of the lengths of any two sides of a triangle must be greater than or equal to the length of the third side");
        
        X = x;
        Y = y;
        Z = z;
    }
    
    /// <summary>
    /// Calculates the area of the circle
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Will be thrown if perimeter is equals infinity of the <see cref="double"/></exception>
    public override double CalculateArea()
    {
        double perimeter = X + Y + Z;
        if (double.IsInfinity(perimeter))
            throw new ArgumentOutOfRangeException(nameof(perimeter), "Perimeter of this triangle is too big for double");
        
        // Semiperimeter
        double sp = perimeter / 2;
        // Using Heron's formula
        // See: https://en.wikipedia.org/wiki/Heron%27s_formula
        return Math.Sqrt(sp * (sp - X) * (sp - Y) * (sp - Z));
    }   

    /// <summary>
    /// Check if triangle is right
    /// </summary>
    /// <returns></returns>
    public bool IsRight()
    {
        double[] sortedSides = new[] { X, Y, Z }.OrderByDescending(x => x).ToArray();
        double hypotenuse = sortedSides[0];
        double cathetus1 = sortedSides[1];
        double cathetus2 = sortedSides[2];
        
        // Using pythagorean theorem
        return Math.Abs(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2) - Math.Pow(hypotenuse, 2)) <  0.001;
    }
}