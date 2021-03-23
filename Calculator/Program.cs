using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Druk op (+) om de getallen op te tellen.");
            Console.WriteLine("Druk op (*) om de getallen te vermenigvuldigen.");
            Console.WriteLine("Druk op (-) om de getallen van elkaar af te trekken");
            Console.WriteLine("Druk op (:) om de getallen door elkaar te delen.");

            int num01;
            int num02;
            float result;

            var operation = Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Voer een nummer in zonder een komma.");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voer nu nog een nummer in.");
            num02 = Convert.ToInt32(Console.ReadLine());


            if (operation.Key == ConsoleKey.Add)
            {
                result = num01 + num02;
            } else if (operation.Key == ConsoleKey.Multiply)
            {
                result = num01 * num02;
            } else if (operation.Key == ConsoleKey.Subtract)
            {
                result = num01 - num02;
            } else if (operation.Key == ConsoleKey.Divide)
            {
                result = num01 / num02;
            } else
            {
                Console.WriteLine("Ik weet niet wat je bedoelt");
                result = 0;
            }

            
            Console.WriteLine("Het antwoord is " + result);
        }
    }
}
