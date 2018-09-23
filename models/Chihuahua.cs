using System;

namespace inheritance.Models
{
  public class Chihuahua : Dog
  {
    public bool Brave { get; set; }

    public override void Speak()
    {
      Console.WriteLine("Yip");
    }

    public Chihuahua(string name, bool tail, int age, bool brave) : base(tail, name, age)
    {
      Brave = brave;
    }
  }
}