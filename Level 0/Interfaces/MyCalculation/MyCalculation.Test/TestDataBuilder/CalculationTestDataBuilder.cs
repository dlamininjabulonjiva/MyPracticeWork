using NSubstitute;

namespace MyCalculation.Test.TestDataBuilder
{
  public class CalculationTestDataBuilder
  {
    private readonly ICalculator _calculator;

    public CalculationTestDataBuilder()
    {
      _calculator = Substitute.For<ICalculator>();
    }

    public Calculation Build()
    {
      return new Calculation(_calculator);
    }

    public CalculationTestDataBuilder WithAddition(int num1, int num2, int total)
    {
      _calculator.Addition(num1, num2).Returns(total);
      return this;
    }

    public CalculationTestDataBuilder WithSubtraction(int num1, int num2, int total)
    {
      _calculator.Subtraction(num1, num2).Returns(total);
      return this;
    }

    public CalculationTestDataBuilder WithDivision(int num1, int num2, int total)
    {
      _calculator.Division(num1, num2).Returns(total);
      return this;
    }

    public CalculationTestDataBuilder WithMultiplication(int num1, int num2, int total)
    {
      _calculator.Multiplication(num1, num2).Returns(total);
      return this;
    }
  }
}
