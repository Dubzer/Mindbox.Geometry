using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox.Geometry.Tests;

[TestClass]
public class FigureTest
{
    [TestMethod]
    [DataRow(3, 4, 5, 6)]
    public void Figure_Triangle_TypeShouldBeInferrable(double x, double y, double z, double result)
    {
        var triangle = new Triangle(x, y, z);
        var upcastedTriangle = (Figure)triangle;
        
        double actual = upcastedTriangle.CalculateArea();
        
        Assert.AreEqual(result, actual);
    }
    
    [TestMethod]
    [DataRow(5, 78.539)]
    public void Figure_Circle_TypeShouldBeInferrable(double radius, double result)
    {
        var circle = new Circle(radius);
        var upcastedCircle = (Figure)circle;

        double actual = upcastedCircle.CalculateArea();
        
        Assert.AreEqual(result, actual, 0.001);
    }
}