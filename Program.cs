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
// we'll hand off the list of employee names to the caller of the method, we must make sure to return it at the end of the method. 
// This fulfills the contract we created in the method signature, which promises to return a list of strings 
// To get the application functioning correctly, we need to call this method from Main(), 
// in the place where we pulled out the employee-getting code
