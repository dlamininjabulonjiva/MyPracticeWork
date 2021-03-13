using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculation
{
  public interface ICalculator
  {
    int Addition(int num1, int num2);
    int Subtraction(int num1, int num2);
    int Division(int num1, int num2);
    int Multiplication(int num1, int num2);
  }
}
