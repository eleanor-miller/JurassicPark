using System;

namespace JurassicPark
{
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
      Console.WriteLine($"Name: {Name}\nWeight: {Weight} lbs.\nDiet: {DietType}\nAcquired on: {WhenAcquired}\nLocation: Enclosure {EnclosureNumber} ");
    }
  }

}
