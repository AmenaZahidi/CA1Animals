namespace CA1Animals;

using System;


    internal class Adopter : User
    {
        private static int nextID = 1;

        
        public Adopter(string name, string email, string password)
            : base(nextID++, name, email, password)
        {
            // nextID++;
        }

        public override void DisplayMenu()
        {
            Console.WriteLine("+ ---------------------------------------+");
            Console.WriteLine("|               Adopter Menu             |");
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|1. View All Adoptable Animals            |");
            Console.WriteLine("|2. Filter by Type                        |");
            Console.WriteLine("|3. Exit                                  |");
            Console.WriteLine("+-----------------------------------------+");
        }
/// <summary>
///  Displays a menu it allows   user to view adoptable animls
///
///  it filtr them by type or exit program
/// </summary>
/// <returns> exit the menu</returns>
        public override bool Menu()
        {
            bool exit = false;

            while (!exit)
            {
                DisplayMenu();
                Console.Write("Enter choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Enter a number.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1: 
                        foreach (var a in AnimalList)
                            if (a.Adoption)
                                Console.WriteLine(a);
                        break;

                    case 2:  // fillter animal
                        AnimalType selectedType = SelectAnimalType();
                        foreach (var a in AnimalList)
                            if (a.Type == selectedType && a.Adoption)
                                Console.WriteLine(a);
                        break;

                    case 3: // Exit
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Choose 1-3.\n");
                         continue;
                }
            }

            return exit;
        }
        
/// <summary>
/// ask the user to select an animal type  , dog cat, rabbit
/// </summary>
/// <returns>  AnimalType value  </returns>
// 
        private AnimalType SelectAnimalType()
        {
            AnimalType type = 0; 
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine("Select Animal Type:");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine("3. Rabbit");
                Console.Write("Your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        type = AnimalType.DOG;
                        break;
                    case "2":
                        type = AnimalType.CAT;
                        validChoice = true;
                        break;
                    case "3":
                        type = AnimalType.RABBIT;
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Enter 1, 2, or 3.\n");
                        break;
                }
            }

            return type;
        }

    }

