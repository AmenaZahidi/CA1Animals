namespace CA1Animals;

public class ConcreteAnimal : Animal
{
   
    /// <summary>
    ///   basic animal that can be adopted or fostered
    /// </summary>
    public bool NeedsFoster { get; set; }  

    public ConcreteAnimal(
        string name, 
        AnimalType type, 
        int age, 
        bool vaccinated, 
        bool adoption,
        bool needsFoster)
        : base(name, type, age, vaccinated, adoption)
    {
        NeedsFoster = needsFoster;
    }
/// <summary>
///  gets simple text about this animal
/// </summary>
/// <returns></returns>
    public override string ToString()
    {
        return base.ToString() +$", Needfoster: {NeedsFoster}";
    }
}