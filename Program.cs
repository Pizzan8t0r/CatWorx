using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
{
  // get employee method
static List<Employee> GetEmployees()
{
List<Employee> employees = new List<Employee>();
while(true) 
{
  // Move the initial prompt inside the loop, so it repeats for each employee
  Console.WriteLine("Enter first name (leave empty to exit): ");

  // change input to firstName
  string firstName = Console.ReadLine() ?? "";
  if (firstName == "") 
  {
    break;
  }

  // add a Console.ReadLine() for each value
  Console.Write("Enter last name: ");
  string lastName = Console.ReadLine() ?? "";
  Console.Write("Enter ID: ");
  int id = Console.ReadLine() ?? "";
  Console.Write("Enter Photo URL:");
  string photoUrl = Console.ReadLine() ?? "";
  Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
  employees.Add(currentEmployee);
  }

  return employees;
}
  
  // if a static method wants to call another method inside the same class directly, that method must also be static
// print employee method
  static void PrintEmployees(List<Employee> employees)
  {
    for (int i = 0; i < employees.Count; i++)
    {
      Console.WriteLine(employees[i].GetFullName());
    }
  }

  static void Main(string[] args)
  {
    List<Employee> employees = GetEmployees();
    PrintEmployees(employees);
   }
  }
 }
 // Create a new Employee instance
 
// GetEmployees() had a return type but no parameters. 
// PrintEmployees() will require a parameter but won't have a return type.
// Because we'll hand off the list of employee names to the caller of the method, we must make sure to return it at the end of the method. 
// This fulfills the contract we created in the method signature, which promises to return a list of strings
// C# provides a dictionary structure, which can store keys and values similar to Javascript objects. This might seem like a candidate for storing the employee data  
// Dictionaries can only store values of the same type