using System.Reflection.Metadata.Ecma335;

namespace CA1Animals;

internal class ShelterManager : User

{
    private static int nextID = 1;

    public ShelterManager(Shelter shelter, string name, string email, string password)
        : base(nextID++, name, email, password)
    {

    }

    /// <summary>
    /// shows the shlter manger menu
    /// </summary>

    public override void DisplayMenu()
    {
        Console.WriteLine("+------------------------------------------+");
        Console.WriteLine("|             Shelter Manager Menu         |");
        Console.WriteLine("+------------------------------------------+");
        Console.WriteLine("| 1. Add Animal                            |");
        Console.WriteLine("| 2. View All Animals                      |");
        Console.WriteLine("| 3. Back                                  |");
        Console.WriteLine("+------------------------------------------+");

    }

    /// <summary>
    /// Runs the menu loop fpr the manager
    ///  
    /// </summary>
    /// <returns> true if the user exits</returns>

    public override bool Menu()
    {
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();
            int choice;
            if (!Validators.TryInt(input, out choice))
            {
                Console.WriteLine("Please enter a number.\n");
                continue;
            }


            switch (choice)
            {
                case 1:
                    AddAnimal();
                    break;

                case 2:
                    User.DisplayAllAnimals();
                    break;

                case 3:
                    exit = true;
                    Console.WriteLine("Exiting Shelter Manager Menu...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Choose 1-3.\n");
                    break;
            }
        }

        return exit;
    }


/// <summary>
///  ask for details and add a new animal 
/// </summary>

        private void AddAnimal()
        {
            Console.Write("Enter Animal Name: ");
            string name = Console.ReadLine();

            AnimalType type = SelectAnimalType();

            Console.Write("Enter Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age.\n");
                return;
            }
            bool vaccinated;
            while (true)
            {
                Console.Write("Vaccinated? (y/n): ");
                var yn = Validators.IsYesNo(Console.ReadLine());
                if (yn.HasValue) { vaccinated = yn.Value; break; }
                Console.WriteLine("Type y/yes or n/no.\n");
            }

            bool needsFoster;
            while (true)
            {
                Console.Write("Needs Foster? (y/n): ");
                var yn = Validators.IsYesNo(Console.ReadLine());
                if (yn.HasValue) { needsFoster = yn.Value; break; }
                Console.WriteLine("Type y/yes or n/no.\n");
            }


            // Console.Write("Available for Adoption? (y/n): ");
            // bool adoption = Console.ReadLine().Trim().ToLower() == "y";
            
            bool adoption;
            while (true)
            {
                Console.Write("Available for Adoption? (y/n): ");
                var yn = Validators.IsYesNo(Console.ReadLine());
                if (yn.HasValue) { adoption = yn.Value; break; }
                Console.WriteLine("Type y/yes or n/no.\n");
            }

            var newAnimal = new ConcreteAnimal(name, type, age, vaccinated, adoption, needsFoster);
            User.AnimalList.Add(newAnimal);


            Console.WriteLine($"\n Animal '{name}' added successfully!\n");
        }

       


/// <summary>
/// ask the user to pick  an animal type
/// </summary>
/// <returns></returns>
        private AnimalType SelectAnimalType()
        {
            

            while (true)
            {
                Console.WriteLine("Enter Type (1 = Dog, 2 = Cat, 3 = Rabbit):");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": return AnimalType.DOG;
                    case "2":  return AnimalType.CAT;
                    case "3": return AnimalType.RABBIT;
                    default: Console.WriteLine("Invalid choice! Enter 1, 2, or 3.\n"); break;
                }
            }

       
        }
    }


     

 