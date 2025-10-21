using System.ComponentModel.DataAnnotations;

namespace CA1Animals
{
    public abstract class Animal
    {
        private int animalID;
        private static int nextID = 0;
        private string name;
        private AnimalType type;
        private int age;
        private bool vaccinated;
        private bool adoption;
/// <summary>
/// 
/// </summary>
/// <param name="name"></param>
/// <param name="type"></param>
/// <param name="age"></param>
/// <param name="vaccinated"></param>
/// <param name="adoption"></param>
        protected Animal(string name, AnimalType type, int age, bool vaccinated, bool adoption)
        {
            animalID = nextID++;
            this.name = name;
            this.type = type;
            this.age = age;
            this.vaccinated = vaccinated;
            this.adoption = adoption;
        }

        
        public int AnimalID
        {
            get { return animalID; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AnimalType Type
        {
            get { return type; }
            set { type = value; }
        }

        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool Vaccinated
        {
            get { return vaccinated; }
            set { vaccinated = value; }
        }

        public bool Adoption
        {
            get { return adoption; }
            set { adoption = value; }
        }

        
        public override string ToString()
        {
            return $"ID: {animalID}, Type: {type}, Name: {name}, " +
                   $"Age: {age}, Vaccinated: {vaccinated}, Adoptable: {adoption}";
        }
    }
}