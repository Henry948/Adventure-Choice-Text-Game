using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      // THE MYSTERIOUS NOISE EXTENSIVE TESTING CARRIED OUT. PROGRAM WORKS!
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      
      Console.Write("It beigns on a cold rainy night.");
      Console.Write(" You're sitting in your room and hear a noise coming from down the hall.");
      Console.Write(" Do you go to investigate?");
      
      Console.Write(" Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();

      if (noiseChoice == "NO") {

        Console.Write("Not much of an adventure");
        Console.Write(" if we never leave our room!");

      } else if (noiseChoice == "YES") {

        Console.Write("You walk into the ");
        Console.Write("hallway and see ");
        Console.Write("a light coming from under a door ");
        Console.Write("down the hall. ");
        Console.Write("you walk towards it. ");
        Console.Write("do you open it or knock? ");
        Console.Write(" Type OPEN or KNOCK: ");

      }
        string doorChoice = Console.ReadLine();
        doorChoice = doorChoice.ToUpper();

        if (doorChoice == "OPEN") {
          Console.WriteLine("The door is locked! See if one of your keys will open it!");

          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine();

          switch (keyChoice){
            case "1":
            Console.Write("You chose the first key! ");
            Console.Write("Lucky Choice! ");
            Console.Write("The door opens and NOTHING is there. ");
            Console.Write("Strange... ");
            Console.Write("THE END.");
            break;
            case "2":
            Console.Write("You chose the second key! ");
            Console.Write("The door doesnt open ");
            Console.Write("THE END");
            break;
            case "3":
            Console.Write("You chose the third key! ");
            Console.Write("The door doesnt open ");
            Console.Write("THE END");
            break;
            default:
            break;
          }
    

        } else if (doorChoice == "KNOCK") {

                Console.Write("A voice behind the door speaks. It says, ");
          Console.Write("Answer this riddle: ");
          Console.Write("Poor people have me. ");
          Console.Write("Rich people need me. ");
          Console.Write("If you eat me, you die. What am i? ");

          Console.Write("Type your Answer: ");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();

          if (riddleAnswer == "NOTHING") {
            Console.Write("The door opens and NOTHING is there. ");
            Console.Write("You turn off the light and run back to your room and lock the door. ");
            Console.Write("THE END. ");
          } else {
            Console.WriteLine("INCORRECT answer. The door doesnt open. THE END");
          }
        }
      }
    }
  }

