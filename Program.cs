using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
{
  // get employee method
  static List<string> GetEmployees()
  {
    List<string> employees = new List<string>();
    while (true)
    {

      Console.WriteLine("Please enter a name: (leave empty to exit): ");

      string input = Console.ReadLine() ?? "";

      if (input == "")
      {
        break;
      }
      employees.Add(input);
    }
    return employees;
  }
  // if a static method wants to call another method inside the same class directly, that method must also be static
// print employee method
  static void PrintEmployees(List<string> employees)
  {
    for (int i = 0; i < employees.Count; i++)
    {
      Console.WriteLine(employees[i]);
    }
  }

  static void Main(string[] args)
  {
    List<string> employees = GetEmployees();
    PrintEmployees(employees);
   }
  }
 }
 
// GetEmployees() had a return type but no parameters. 
// PrintEmployees() will require a parameter but won't have a return type.
// Because we'll hand off the list of employee names to the caller of the method, we must make sure to return it at the end of the method. 
// This fulfills the contract we created in the method signature, which promises to return a list of strings
// C# provides a dictionary structure, which can store keys and values similar to Javascript objects. This might seem like a candidate for storing the employee data  
// Dictionaries can only store values of the same type