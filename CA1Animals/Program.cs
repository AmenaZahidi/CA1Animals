using System;

namespace CA1Animals
{
    internal class Program
    {
        /// <summary>
        ///  the animals shetlter app & shows the main menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            
            
            var shelter = new Shelter();
            var manager   = new ShelterManager(shelter, "Manager1", "manager@email.com", "pass1");
            var fosterer = new Fosterer("Jane Foster", "foster@email.com", "pass3");
            var vetUser = new vet("Dr. Smith", "vet@email.com", "pass2");
            var adopter  = new Adopter("Alex", "adopter@email.com", "pass4");

            SeedTestData();

            bool isExit = false;

            while (!isExit)
            {
                DisplayMainMenu();
                Console.Write("\nEnter Menu Choice: ");
                string input = Console.ReadLine();
                int menuOption;
                if (!Validators.TryInt(input, out menuOption))
                {
                    Console.WriteLine("Please enter a number.\n");
                    continue; 
                }

                switch (menuOption)
                {
                    case 1:
                        manager.Menu();
                        break;

                    case 2:
                        vetUser.Menu();
                        break;

                    case 3:
                        fosterer.Menu();
                        break;

                    case 4:
                        adopter.Menu();
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu option (1–5).\n");
                        break;
                }
            }
        }
                  /// <summary>
                  ///  shows the main menu on the screen
                  /// </summary>
        public static void DisplayMainMenu()
        {
            Console.WriteLine("+-----------------------------------------+\n" +
                              "|         Animal Shelter System           |\n" +
                              "+-----------------------------------------+\n" +
                              "|1. Shelter Manager                       |\n" +
                              "|2. Vet                                   |\n" +
                              "|3. Fosterer                              |\n" +
                              "|4. Adopter                               |\n" +
                              "|5. Exit                                  |\n" +
                              "+-----------------------------------------+");
        }
/// <summary>
///  addes a few sample animasl to the system2
/// 
/// </summary>
        public static void SeedTestData()
        {
            User.AnimalList.Add(new ConcreteAnimal("Buddy",    AnimalType.DOG,    3, true,  false, true));
            User.AnimalList.Add(new ConcreteAnimal("Misty",    AnimalType.CAT,    2, false, true,  false));
            User.AnimalList.Add(new ConcreteAnimal("Snowball", AnimalType.RABBIT, 1, true,  true,  true));

            Console.WriteLine("Test data loaded successfully!\n");
        }
    }
}
