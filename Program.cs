using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
    {
       static void Main(string[] args)
{
  static List<string> GetEmployees()
{
  List<string> employees = new List<string>();
  while (true) 
  {
    // This method doesn't need parameters, because it will know how to get employee names from the user all by itself. 
    // Now we can move all of the employee-getting code from Main() into this new method
    Console.WriteLine("Please enter a name: (leave empty to exit): ");
    string input = Console.ReadLine() ?? "";
    if (input == "") 
    {
      break;
    }

    employees.Add(input);
  }
  // This is important!
  return employees;
}
  }
 } 
}
