using System;

namespace inheritance.Models
{
  public class GreatDane : Dog
  {
    public bool Graceful { get; set; }
    public GreatDane(bool tail, string name, int age, bool graceful) : base(tail, name, age)
    {
      Graceful = graceful;
    }
  }
}