using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculation
{
  public class Calculation
  {
    private readonly ICalculator _calculator;

    public Calculation(ICalculator calculator)
    {
      _calculator = calculator;
    }

    public int AddTwoNumbers(int num1, int num2)
    {
      var total = _calculator.Addition(num1, num2);
      return total;
    }

    public int GetTheDifference(int num1, int num2)
    {
      var total = _calculator.Subtraction(num1, num2);
      return total;
    }

    public int DivideTwoNumbers(int num1, int num2)
    {
      var total = _calculator.Division(num1, num2);
      return total;
    }

    public int MultiplyTwoNumbers(int num1, int num2)
    {
      var total = _calculator.Multiplication(num1, num2);
      return total;
    }
  }
}
