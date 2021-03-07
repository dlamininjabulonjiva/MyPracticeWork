using System;

namespace MyMath
{
  public class MyCalculation
  {
    public int Total { get; set; }

    public MyCalculation(int total)
    {
      Total = total;
    }

    public void AddSumToTotal(int input1, int input2)
    {
      Total += input1 + input2;
    }

    public void AddDifferenceToTotal(int input1, int input2)
    {
      Total += input1 - input2;
    }

    public void AddMultiplicationToTotal(int input1, int input2)
    {
      Total += input1 * input2;
    }

    public void AddDivisionToTotal(int input1, int input2)
    {
      Total += input1 / input2;
    }
  }
}