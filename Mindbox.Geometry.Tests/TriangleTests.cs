using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox.Geometry.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    [DataRow(2, 2, 2)]
    [DataRow(3, 4, 5)]
    public void Triangle_Constructor_ValidArguments(double x, double y, double z)
    {
        var triangle = new Triangle(x, y, z);
        Assert.AreEqual((triangle.X, triangle.Y, triangle.Z), (x, y, z));
    }

    [TestMethod]
    [DataRow(0, 0, 0)]
    [DataRow(1, 2, 3)]
    [DataRow(2, 3, 1)]
    [DataRow(3, 2, 1)]
    public void Triangle_Constructor_ThrowsExceptionOnInvalidArguments(double x, double y, double z)
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(x, y, z));
    }
    
    [TestMethod]
    [DataRow(3, 4, 5, 6)]
    public void Triangle_CalculateArea_ValidReturnValue(double x, double y, double z, double result)
    {
        double area = new Triangle(x, y, z).CalculateArea();
        Assert.AreEqual(area, result, 0.001);
    }
    
    [TestMethod]
    [DataRow(15, 8, 17, true)]
    [DataRow(3, 3, 3, false)]
    public void Triangle_IsRight_ValidReturnValue(double x, double y, double z, bool result)
    {
        bool isRight = new Triangle(x, y, z).IsRight();
        Assert.AreEqual(isRight, result);
    }
}