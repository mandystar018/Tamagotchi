using System;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name { get; }
    public int Hunger { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public int Hygiene { get; set; }
    public Pet(string name) 
    {
      Name = name;
      Hunger = 10;
      Attention = 5;
      Rest = 15;
      Hygiene = 10;
    }

    public void Feed()
    {
      
    }
  }
}
