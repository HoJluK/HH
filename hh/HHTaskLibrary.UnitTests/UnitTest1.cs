using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HHTaskLibrary.UnitTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void isStraightTriangle_NotStraight_ReturnFalse()
		{
			//Arrange
			var triangle = new Triangle("Треугольник", 2,3,4);

			//Act
			var result = triangle.isStraightTriangle();

			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Square_3and4and5_Return6()
		{
			//Arrange
			var triangle = new Triangle("Треугольник", 3, 4, 5);
			double expected = 6;

			//Act
			var result = triangle.Square();

			//Assert
			Assert.AreEqual(expected, result);
		}
	}

	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Square_5_Return78_5()
		{
			//Arrange
			var circle = new Circle("Круг", 5);
			double expected = 78.5;

			//Act
			var result = circle.Square();

			//Assert
			Assert.AreEqual(expected, result);
		}
	}
}
