using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
{
  // get employee method
  static List<Employee> GetEmployees()
  {
    List<Employee> employees = new List<Employee>();
    while (true)
{
  Console.WriteLine("Please enter a name: (leave empty to exit): ");
  string input = Console.ReadLine() ?? "";
  if (input == "")
  {
    break;
  }
  Employee currentEmployee = new Employee(input, "Smith");
  // Add currentEmployee, not a string
  employees.Add(currentEmployee);
}
    return employees;
    // Create a new Employee instance
   
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