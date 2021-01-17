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

      string firstChoice = Console.ReadLine();
      if (firstChoice == "NO") {
        Console.WriteLine("Not much of an adventure");
        Console.WriteLine(" if we never leave our room!");
      } else if (firstChoice == "YES") {
        Console.WriteLine("You walk into the");
        Console.WriteLine("hallway and see");
        Console.WriteLine("a light coming from under a door");
        Console.WriteLine("down the hall.");
        Console.WriteLine("you walk towards it.");
        Console.WriteLine("do you open it or knock?");
      }

      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();
     
    }
  }
}

