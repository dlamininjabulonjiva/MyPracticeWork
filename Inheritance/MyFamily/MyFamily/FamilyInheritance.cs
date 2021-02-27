using System;
using Microsoft.VisualBasic;

namespace MyFamily
{
  public class FamilyInheritance
  {
    public static void Main(string[] args)
    {
      //instances
      Console.WriteLine("Information of the first child!!!!");
      var childOne = ChildOneInformation();
      childOne.PrintChildOne();

      Console.WriteLine();

      Console.WriteLine("Information of the second child!!!!");
      var childTwo = ChildTwoInformation();
      Console.WriteLine("The new personality for the second child: " + childTwo.Personality);

      Console.WriteLine();

      Console.WriteLine("Information of the grand child!!!!");
      var grandChild = GrandChildInformation();
      grandChild.PrintGrandChild();

      Console.ReadKey();
    }

    private static GrandChild GrandChildInformation()
    {
      var grandChild = new GrandChild {GrandChildName = "Elvin", GrandChildAge = 3, GrandChildGender = "Male"};
      return grandChild;
    }

    private static ChildOne ChildOneInformation()
    {
      var childOne = new ChildOne
      {
        ChildOneName = "Dwayne",
        Surname = "Bravo",
        ChildOneAge = 25,
        ChildOneGender = "Male",
        SkinColor = "Black",
        BloodType = "O",
        Personality = "Openness"
      };
      return childOne;
    }

    private static ChildTwo ChildTwoInformation()
    {
      var childTwo = new ChildTwo
      {
        ChildTwoName = "Susan",
        Surname = "Bravo",
        ChildTwoAge = 20,
        ChildTwoGender = "Female",
        SkinColor = "Black",
        BloodType = "O",
        Personality = "Openness"
      };
      childTwo.PrintChildTwo();
      return childTwo;
    }

    //base class
    public class Parent
    {
      public string Surname;
      public string BloodType;
      public string SkinColor;
      public string Personality;

      public void PrintParent()
      {
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("BloodType: " + BloodType);
        Console.WriteLine("SkinColor: " + SkinColor);
        Console.WriteLine("Personality: " + Personality);
      }
    }

    //derived class
    public class ChildOne : Parent
    {
      public string ChildOneName;
      public int ChildOneAge;
      public string ChildOneGender;

      public void PrintChildOne()
      {
        Console.WriteLine("Name: " + ChildOneName);
        PrintParent();
        Console.WriteLine("Gender: " + ChildOneGender);
        Console.WriteLine("Age: " + ChildOneAge);
      }
    }
    
    //derived class
    public class ChildTwo : Parent
    {
      public string ChildTwoName;
      public int ChildTwoAge;
      public string ChildTwoGender;

      public void PrintChildTwo()
      {
        Console.WriteLine("Name: " + ChildTwoName);
        PrintParent();
        Console.WriteLine("Gender: " + ChildTwoGender);
        Console.WriteLine("Age: " + ChildTwoAge);
        //child 2 has a new personality
        Personality = "Agreeableness";
      }
    }
    
    //inheriting from a derived class
    public class GrandChild : ChildTwo
    {
      public string GrandChildName;
      public int GrandChildAge;
      public string GrandChildGender;

      public void PrintGrandChild()
      {
        Surname = "Gayle";
        BloodType = "A";
        SkinColor = "Black";
        Personality = "Agreeableness";

        Console.WriteLine("Name: " + GrandChildName);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("BloodType: " + BloodType);
        Console.WriteLine("SkinColor: " + SkinColor);
        Console.WriteLine("Personality: " + Personality);
        Console.WriteLine("Gender: " + GrandChildGender);
        Console.WriteLine("Age: " + GrandChildAge);
      }
    }
  }
}
