using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankAccount
{
  public class BankAccount
  {
    private string _customerName;
    private double _balance;

    public BankAccount(string customerName, double balance)
    {
      _customerName = customerName;
      _balance = balance;
    }

    public double Balance
    {
      get => _balance;
      set => _balance = value;
    }

    public void Debit(double amount)
    {
      if (_balance == 0)
      {
        throw new InvalidOperationException("Your Balance is 0");
      }

      if (amount > _balance)
      {
        throw new InvalidOperationException("Amount is greater than your balance");
      }

      _balance -= amount;
    }

    public void Credit(double amount)
    {
      if (amount < 0)
      {
        throw new InvalidOperationException("Amount provided is less than 0");
      }

      _balance += amount;
    }
  }
}
