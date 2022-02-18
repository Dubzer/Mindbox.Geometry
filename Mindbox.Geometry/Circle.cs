namespace Mindbox.Geometry;

/// <summary>
/// Class that represents a circle
/// </summary>
public class Circle : Figure
{
    // Calculated by using Math.Sqrt(double.MaxValue/Math.PI)
    private const double MaxRadiusForArea = 7.5645455722826181E+153;
    public readonly double Radius;
    
    /// <summary>
    /// Create a circle by radius 
    /// </summary>
    /// <param name="radius">A radius of the circle. Radius must be a positive number that's greater than zero.</param>
    /// <exception cref="ArgumentOutOfRangeException">Will be thrown if radius is negative/equals zero</exception>
    public Circle(double radius)
    {
        // This condition includes zero because circle with r=0 is a degenerate case.
        // See: https://en.wikipedia.org/wiki/Circle
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be a positive number that's greater than zero");
        
        Radius = radius;
    }
    
    /// <summary>
    /// Calculates the area of the circle
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Will be thrown if radius of the circle is greater than <see cref="MaxRadiusForArea"/></exception>
    public override double CalculateArea()
    {
        // If radius will be greater than MaxRadiusForArea
        // We wouldn't be able to fit the area in the double 
        if (Radius >= MaxRadiusForArea)
            throw new ArgumentOutOfRangeException(nameof(Radius), "The radius of the circle is too big");
        
        return Math.PI * Math.Pow(Radius, 2);
    }
}