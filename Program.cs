using System;
using System.Collections.Generic;
using System.Linq;

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

        // TEST CODE
        DinosaurDatabase.Add("Sara", "Herbivore", 12500, 3);
        DinosaurDatabase.Add("Rex", "Carnivore", 13000, 1);
        DinosaurDatabase.Add("Steve", "Carnivore", 8000, 1);
        DinosaurDatabase.Add("Buttons", "Herbivore", 2, 100);
        DinosaurDatabase.Add("Godzilla", "Carnivore", 328000000, 1);

        DinosaurDatabase.View("Name");
        DinosaurDatabase.View("Enclosure Number");
      }

    }

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
      Console.WriteLine("-------------------------------------");

    }

    public static Dinosaur Add(string name, string diet, int weight, int enclosure)
    {
      Dinosaur newDinosaur = new Dinosaur(name, diet, weight, enclosure);
      dinosaurs.Add(newDinosaur);
      return newDinosaur;
    }
  }

  public class Dinosaur
  {
    public string Name { get; set; }
    public string DietType { get; set; }
    public double Weight { get; set; }
    public DateTime WhenAcquired { get; set; }
    public int EnclosureNumber { get; set; }

    public Dinosaur(string name, string diet, int weight, int enclosure)
    {
      Name = name;
      DietType = diet;
      Weight = weight;
      WhenAcquired = DateTime.Now;
      EnclosureNumber = enclosure;
    }

    public void Description()
    {
      Console.WriteLine($"Name: {Name}\nWeight: {Weight} lbs.\nDiet: {DietType}\nAcquired on: {WhenAcquired}\nLocation: Enclosure {EnclosureNumber}");
    }
  }

}
