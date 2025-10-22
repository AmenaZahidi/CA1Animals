namespace CA1Animals;

using System;



    internal class Fosterer : User
    {
        private static int nextID = 1;
        

        public Fosterer(string name, string email, string password)
            : base(nextID++, name, email, password)
        {
            
        }
        /// <summary>
        /// DisplayMenus
        /// </summary>

        public override void DisplayMenu()
        {
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|              Fosterer Menu              |");
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|1. View Animals Needing Foster           |");
            Console.WriteLine("|2. Exit                                  |");
            Console.WriteLine("+-----------------------------------------+");
        }

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
                        foreach (var a in AnimalList)
                            if (a is ConcreteAnimal ca && ca.NeedsFoster)
                                Console.WriteLine(a);
                        Console.WriteLine();
                        break;

                    case 2:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
            return exit;
        }
    }

