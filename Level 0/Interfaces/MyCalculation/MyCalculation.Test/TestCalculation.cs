using MyCalculation.Test.TestDataBuilder;
using NUnit.Framework;

namespace MyCalculation.Test
{
  [TestFixture]
  public class TestCalculation
  {
    [Test]
    public void ShouldAddTwoNumbers_AndReturnTheTotal()
    {
      // Arrange
      const int num1 = 15;
      const int num2 = 25;
      const int total = 40;

      var sut = new CalculationTestDataBuilder()
        .WithAddition(num1, num2, total)
        .Build();
      // Act
      var actual = sut.AddTwoNumbers(num1, num2);
      // Assert
      Assert.AreEqual(total, actual);
    }

    [Test]
    public void ShouldSubtractTwoNumbers_AndReturnTheTotal()
    {
      // Arrange
      const int num1 = 150;
      const int num2 = 50;
      const int total = 100;

      var sut = new CalculationTestDataBuilder()
        .WithSubtraction(num1, num2, total)
        .Build();
      // Act
      var actual = sut.GetTheDifference(num1, num2);
      // Assert
      Assert.AreEqual(total, actual);
    }

    [Test]
    public void ShouldDivideTwoNumbers_AndReturnTheTotal()
    {
      // Arrange
      const int num1 = 150;
      const int num2 = 2;
      const int total = 75;

      var sut = new CalculationTestDataBuilder()
        .WithDivision(num1, num2, total)
        .Build();
      // Act
      var actual = sut.DivideTwoNumbers(num1, num2);
      // Assert
      Assert.AreEqual(total, actual);
    }

    [Test]
    public void ShouldMultiplyTwoNumbers_AndReturnTheTotal()
    {
      // Arrange
      const int num1 = 25;
      const int num2 = 5;
      const int total = 125;

      var sut = new CalculationTestDataBuilder()
        .WithMultiplication(num1, num2, total)
        .Build();
      // Act
      var actual = sut.MultiplyTwoNumbers(num1, num2);
      // Assert
      Assert.AreEqual(total, actual);
    }
  }
}
