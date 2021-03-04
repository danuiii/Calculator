using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num01;
            int num02;

            Console.WriteLine("Voer een nummer in zonder komma.");
            num01 = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Voer nu nog een nummer in.");
            num02 = Convert.ToInt32(Console.ReadLine());

            int result = num01 * num02;
            Console.WriteLine("Het antwoord is " + result);

            Console.ReadKey();
        }
    }
}
