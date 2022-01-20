using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un codigo");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce segundo codigo");

            int num2 = int.Parse(Console.ReadLine());

            int numTotal = num1 + num2;

            Console.WriteLine($"La suma és: {numTotal}");
             
        }
    }
}
 