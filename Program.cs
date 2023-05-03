using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");
            Console.WriteLine(!isCold ? "drink" : "add ice");


        }
    }
}

// drnk
// add ice