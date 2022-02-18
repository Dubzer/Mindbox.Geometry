using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox.Geometry.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    [DataRow(double.PositiveInfinity)]
    [DataRow(1)]
    public void Circle_Constructor_ValidArguments(double radius)
    {
        Assert.AreEqual(new Circle(radius).Radius, radius);
    }
    
    [TestMethod]
    [DataRow(double.NegativeInfinity)]
    [DataRow(-1)]
    [DataRow(0)]
    public void Circle_Constructor_ThrowsExceptionOnInvalidArguments(double radius)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [TestMethod]
    [DataRow(double.PositiveInfinity)]
    [DataRow(7.5645455722826181E+153)]
    public void Circle_CalculateArea_ThrowsExceptionOnInvalidArguments(double radius)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(radius).CalculateArea());
    }
    
    [TestMethod]
    [DataRow(1, Math.PI)]
    [DataRow(5, 78.539)]
    public void Circle_CalculateArea_ValidReturnValue(double radius, double result)
    {
        double area = new Circle(radius).CalculateArea();
        Assert.AreEqual(area, result, 0.001);
    }
}