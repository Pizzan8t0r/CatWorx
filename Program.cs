using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *

Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3

Console.WriteLine(1 + 2 * 3);     // order of operations

Console.WriteLine(10 / 3.0);      // int's and doubles

Console.WriteLine(10 / 3);        // int's 

Console.WriteLine("12" + "3");    // What happens here?

int num = 10;

num += 100;

Console.WriteLine(num);

num ++;

Console.WriteLine(num);
        }
    }
}

// 6
// 1
// 7
// 3.3333333333333335
// 3
// 123
// 110
// 111