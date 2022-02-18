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
        Assert.AreEqual(result, upcastedTriangle.CalculateArea());
    }
    
    [TestMethod]
    [DataRow(5, 78.539)]
    public void Figure_Circle_TypeShouldBeInferrable(double radius, double result)
    {
        var circle = new Circle(radius);
        var upcastedCircle = (Figure)circle;
        Assert.AreEqual(result, upcastedCircle.CalculateArea(), 0.001);
    }
}