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
      this.Hunger += 2;
      this.Attention -= 2;
      this.Rest -= 3;
      this.Hygiene -=5;
      GameOver();
    }
    public void Play()
    {
      this.Hunger -= 3;
      this.Attention += 2;
      this.Rest -= 5;
      this.Hygiene -=2;
      GameOver();
    }

    public void Sleep()
    {
      this.Hunger -= 5;
      this.Attention -= 3;
      this.Rest += 2;
      this.Hygiene -= 2;
      GameOver();
    }

    public void Clean()
    {
      this.Hunger -= 1;
      this.Rest -= 3;
      this.Hygiene += 2;
      GameOver();
    }
    public string GameOver()
    {
      if (this.Hunger == 0 || this.Rest == 0 || this.Hygiene == 0 || this.Attention == 0)
      {
        return "Your " + this.Name + "died";
      }
      else return "Now " + this.Name + " is Happy!";
    }
  }
}
