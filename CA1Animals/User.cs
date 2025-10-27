using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace CA1Animals;

public  abstract class User
{
    
    /// <summary>
    /// shared  list of all animals in the system 
    /// </summary>
     public static  List<Animal>  AnimalList = new List<Animal>();
    
     
      protected string name;
      protected int id;
      protected string email; 
      protected string password;


    

      public string Name
      {
          get => name;
          set
          {
              if (!string.IsNullOrWhiteSpace(value)) name = value;
              else Console.WriteLine("Invalid name. Cannot be empty.");
          }
      }

      public string Email
      {
          get => email;
          set
          {
              if (!string.IsNullOrWhiteSpace(value) && value.Contains("@")) email = value;
              else Console.WriteLine("Invalid email format.");
          }
      }

      protected User(int id, string name, string email, string password)
      {
          this.id = id;
          this.name = name;
          this.email = email;
          this.password = password;
      }
/// <summary>
/// Prints  all animals to the screen 
/// </summary>
      public static void DisplayAllAnimals()
      {
          if (AnimalList.Count == 0)
          {
              Console.WriteLine("No animals in the system\n");
              return;
          }

          foreach (var a in AnimalList)
              Console.WriteLine(a);
          Console.WriteLine();
      }

      public abstract void DisplayMenu();
      public abstract bool Menu();
}


