using System;

namespace CA1Animals
{
    internal class vet : User
    {
        private static int nextID = 1;

        public vet(string name,  string email, string password)
            : base(nextID++, name, email, password)
        {
       
        }
        /// <summary>
        /// Show the vet menu.
        /// </summary>
        public override void DisplayMenu()
        {
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|                  Vet Menu               |");
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|1. View All Animals                      |");
            Console.WriteLine("|2. Update Vaccination Status             |");
            Console.WriteLine("|3. Exit   ;)                               |");
            Console.WriteLine("+-----------------------------------------+");
        }
        /// <summary>
        /// Run the vet menu loops
        /// </summary>
        /// <returns>True if the user exits.</returns>
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
                    Console.WriteLine("Invalid input.\n");
                    continue;
                }
                switch (choice)
                {
                    case 1: DisplayAllAnimals(); break;
                    case 2: UpdateVaccination(); break;
                    case 3: exit = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
            return exit;
        }
        /// <summary>
        /// Let the vet set vaccination for a chosen animals
        /// </summary>
        private void UpdateVaccination()
        {
            DisplayAllAnimals();
            Console.Write("Enter Animal ID to update: ");
            string input = Console.ReadLine();
            
            
            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid ID.\n");
                return;
            }

            Animal animal = AnimalList.Find(a => a.AnimalID == id);
            if (animal != null)
            {
                Console.Write("Vaccinated? (y/n): ");
                animal.Vaccinated = (Console.ReadLine() ?? "").Trim().ToLower() is "y" or "yes";
                Console.WriteLine("Vaccination status updated.\n");
            }
            else Console.WriteLine("Animal not found.\n");
        }
    }
}
