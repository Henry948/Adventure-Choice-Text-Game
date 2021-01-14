using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      // THE MYSTERIOUS NOISE 
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      
      Console.Write("It beigns on a cold rainy night.");
      Console.Write(" You're sitting in your room and hear a noise coming from down the hall.");
      Console.Write(" Do you go to investigate?");
      
      Console.Write(" Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
     
    }
  }
}

