namespace CA1Animals;

 using System.Collections.Generic;
 using System.Linq;
 
 /// <summary>
 /// stroes & manages animals in the shelter 
 /// </summary>
 public class Shelter
 
 {
  private readonly List<Animal> animals = new();

  /// <summary>
  /// Addes animal 
  /// </summary>
  /// <param name="animal"></param>
  public void AddAnimal(Animal animal) => animals.Add(animal);

  /// <summary>
  ///  gets  a copy of all animals 
  /// </summary>
  /// <returns></returns>
  public List<Animal> GetAllAnimals() => new List<Animal>(animals);

  /// <summary>
  ///  all animals geiven by type 
  /// </summary>
  /// <param name="type"></param>
  /// <returns></returns>
  public List<Animal> GetAnimalsByType(AnimalType type) =>
   animals.Where(a => a.Type == type).ToList();
 }


