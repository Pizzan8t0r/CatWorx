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
        Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
        }
    }
}
// My employees include adam, amy, barbara, billy