using System.Collections.Generic;
     
namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
         // this bad boy declares a list and its data types using the angle bracket notation, similar to the dictionary
        List<string> employees = new List<string>() { "adam", "amy" };
        employees.Add("barbara");
        employees.Add("billy");
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