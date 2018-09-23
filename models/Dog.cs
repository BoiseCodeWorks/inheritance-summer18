using System;

namespace inheritance.Models
{
  public abstract class Dog
  {
    public bool Tail { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }


    public virtual void Speak()
    {
      Console.WriteLine("Bark");
    }

    public void Eat(string food)
    {
      Console.WriteLine("NOM NOM NOM");
      if (food != "dogfood")
      {
        Console.WriteLine("BARF");
      }
    }

    //Method overloading allows the same method name as long as a different signature exists
    public void Eat(string food, int quantity)
    {
      System.Console.WriteLine("nom nom nom");
      if (quantity > 3)
      {
        Console.WriteLine("barf");
      }
    }

    public Dog(bool tail, string name, int age)
    {
      Tail = tail;
      Name = name;
      Age = age;
    }

  }
}