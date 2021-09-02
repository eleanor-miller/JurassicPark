using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    static class DinosaurDatabase
  {
    static List<Dinosaur> dinosaurs = new List<Dinosaur>() { };

    public static void View(string orderBy)
    {
      // Try to make a Switch later
      if (dinosaurs.Count == 0)
      {
        Console.WriteLine("Who let all the dinosaurs out??? ");
        return;
      }
      
      if (orderBy == "Name")
      {
        dinosaurs = dinosaurs.OrderBy(dinosaur => dinosaur.Name).ToList<Dinosaur>();
      }
      else 
      if (orderBy == "Enclosure")
      {
        dinosaurs = dinosaurs.OrderBy(dinosaur => dinosaur.EnclosureNumber).ToList<Dinosaur>();
      }

      dinosaurs.ForEach(dinosaur => dinosaur.Description());
      Console.WriteLine();
      Console.WriteLine("===========================================================");
      Console.WriteLine();

    }

    public static Dinosaur Add(string name, string diet, int weight, int enclosure)
    {
      Dinosaur newDinosaur = new Dinosaur(name, diet, weight, enclosure);
      dinosaurs.Add(newDinosaur);
      return newDinosaur;
    }

    public static Dinosaur Remove(string name)
    {
      Dinosaur dinosaurToRemove = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name.ToLower() == name.ToLower());
      if (dinosaurToRemove != null)
      {
        dinosaurs.Remove(dinosaurToRemove);
        Console.WriteLine("Dinosaur has been removed!");
      }
      return dinosaurToRemove;
    }

    public static Dinosaur Transfer(string name, int newEnclosure)
    {
      Dinosaur transferDinosaur = dinosaurs.FirstOrDefault(dinosaurs => dinosaurs.Name.ToLower() == name.ToLower());

        if(transferDinosaur != null)
        {
          transferDinosaur.EnclosureNumber = newEnclosure;
          Console.WriteLine($"{name}'s enclosure number has been updated!");
        }

        return transferDinosaur;
    }

    public static void Summary()
    {
      int herbivoreCount = dinosaurs.Where(dinosaurs => dinosaurs.DietType == "Herbivore").Count();
      int carnivoreCount = dinosaurs.Where(dinosaurs => dinosaurs.DietType == "Carnivore").Count();

      Console.WriteLine($"There are {herbivoreCount} herbivores and {carnivoreCount} carnivores in our park! ");
    }
   
  }

}
