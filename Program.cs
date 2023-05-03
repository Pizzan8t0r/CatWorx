using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
    {
       static void Main(string[] args)
{
  List<string> employees = new List<string>();
  // Collect user values until the value is an empty string
  while (true)
  {
    Console.WriteLine("Please enter a name: ");
    string input = Console.ReadLine() ?? "";
    employees.Add(input);
  } 
  for (int i = 0; i < employees.Count; i++) 
  {
    Console.WriteLine(employees[i]);
  }
}
    } 
 }

// adam
// amy
// barbara
// billy