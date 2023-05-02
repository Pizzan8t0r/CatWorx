using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
          string greeting = "Hello";
          greeting = greeting + "World";
          Console.WriteLine("greeting" + greeting);
          Console.WriteLine($"greeting: {greeting}");
          Console.WriteLine("greeting: {0}", greeting);
        }
    }
}
// Output(s)
// greetingHelloWorld
// greeting: HelloWorld
// greeting: HelloWorld