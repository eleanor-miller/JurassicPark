using System;

namespace JurassicPark
{

    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("       🦕 Welcome to Jurassic Park 🦖       ");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();

        bool keepGoing = true;
        string input = "";

        // Try Switch here later
        while (keepGoing)
        {
          Console.WriteLine("What do you want to do?");
          Console.WriteLine("(A)dd a dinosaur\n(R)emove a dinosaur\n(T)ransfer a dinosaur\n(S)ummary of all the dinosaurs\n(V)iew the dinosaurs in a specified order, or ");
          Console.Write("(Q)uit? ");

          input = Console.ReadLine().ToUpper();

          switch (input) 
          {
            case "A":
              string newName;
              string newDiet;
              int newWeight;
              int newEnclosure;

              Console.Write("What is the dinosaur's name? ");
                newName = Console.ReadLine();

              Console.Write("Is the dinosaur a (H)erbivore or (C)arnivore? " );
                string response = Console.ReadLine().ToUpper();
                if (response == "H")
                {
                  newDiet = "Herbivore";                  
                }
                else if (response == "C")
                {
                  newDiet = "Carnivore";                  
                }
                else 
                {
                  Console.WriteLine("Invalid Diet Type.");
                  break;
                }

              Console.Write("What is the weight of the dinosaur in pounds? ");
                newWeight = int.Parse(Console.ReadLine());

              Console.Write($"Which # enclousure would you like to place {newName} in? ");
                newEnclosure = int.Parse(Console.ReadLine());

              DinosaurDatabase.Add(newName, newDiet, newWeight, newEnclosure);

              break;

            case "R":
            Console.Write("What is the name of the dinosaur to be removed? ");
            Dinosaur dinosaurBeingRemoved = DinosaurDatabase.Remove(Console.ReadLine().ToUpper());

            if (dinosaurBeingRemoved != null)
            {
              Console.WriteLine($"{dinosaurBeingRemoved.Name} has been removed!");
            }
            else
            {
              Console.WriteLine("There is no record of this dinosaur, maybe it's extinct? ☄️ ");
            }
              break;

            case "T":
            Console.Write("Which dinosaur would you like to transfer? ");
            string transferDinosaur = Console.ReadLine().ToUpper();

            Console.WriteLine("Which # enclosure should the dinosaur be moved to? ");
            int transferEnclosure = int.Parse(Console.ReadLine());
            Dinosaur dinosaurBeingTransferred = DinosaurDatabase.Transfer(transferDinosaur, transferEnclosure);

            if (dinosaurBeingTransferred != null)
            {
              Console.WriteLine($"{dinosaurBeingTransferred.Name} has been transferred to a enclosure! ");
            }
            else
            {
              Console.WriteLine("There is no record of this dinosaur, maybe it's extinct? ☄️ ");
            }
              break; 

            case "S":
              DinosaurDatabase.Summary();
              break;

            case "V":
            Console.Write("What is the name of the dinosaur would you like to view? ");
            string viewDinosaur = Console.ReadLine().ToUpper();
            
              break;

            case "Q":
              keepGoing = false;
              break;

            default:
              Console.WriteLine("Invalid input.");
              break;
              
          }
        }

        Console.WriteLine("Goodbye!");
      }

    }

}
