using System;

namespace MyAnimal
{
  public class AnimalInheritance
  {
    public static void Main(string[] args)
    {
      //instantiate derived classes
      Console.WriteLine("Information on my Snake");
      var mySnake = new Snake
      {
        Name = "Ana",
        Danger = "Extremely dangerous",
        Color = "Black",
        Type = "Anaconda"
      };
      mySnake.PrintAnimalInfo();
      mySnake.Sound();

      Console.WriteLine();

      Console.WriteLine("Information on my Cat");
      var myCat = new Cat
      {
        Name = "Roman",
        Danger = "Not dangerous at all",
        Color = "White grey",
        Cuteness = "Very Cute"
      };
      myCat.PrintAnimalInfo();
      myCat.Meow();
      Console.WriteLine("My Cat's new color is: " + myCat.Color);

      Console.ReadKey();
    }

    //base class
    public class Animal
    {
      public string Name;
      public string Danger;
      public string Color;

      public void PrintAnimalInfo()
      {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Danger: " + Danger);
        Console.WriteLine("Color: " + Color);
      }
    }

    //derived class
    public class Snake : Animal
    {
      public string Type;

      public void Sound()
      {
        Console.WriteLine("Sound: Hissing and type of snake(" + Type + ")");
      }
    }

    //derived class
    public class Cat : Animal
    {
      public string Cuteness;

      public void Meow()
      {
        Console.WriteLine("Sound: Meow and the cuteness(" + Cuteness + ")");
        //giving my cat a new color
        Color = "Black";
      }
    }
  }
}
