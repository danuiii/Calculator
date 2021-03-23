using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Druk op (+) om de getallen op te tellen.");
                Console.WriteLine("Druk op (X) om de getallen te vermenigvuldigen.");
                Console.WriteLine("Druk op (-) om de getallen van elkaar af te trekken");
                Console.WriteLine("Druk op (:) om de getallen door elkaar te delen.");

                var operationkey = Console.ReadKey();
                var operation = operationkey.Key switch
                {
                    ConsoleKey.Add => Operations.Add,
                    ConsoleKey.A => Operations.Add,
                    ConsoleKey.OemPlus => Operations.Add,

                    ConsoleKey.Subtract => Operations.Subtract,
                    ConsoleKey.OemMinus => Operations.Subtract,

                    ConsoleKey.Divide => Operations.Divide,
                    ConsoleKey.Oem1 when operationkey.Modifiers == ConsoleModifiers.Shift => Operations.Divide,
                    ConsoleKey.Oem2 => Operations.Divide,

                    ConsoleKey.Multiply => Operations.Multiply,
                    ConsoleKey.D8 when operationkey.Modifiers == ConsoleModifiers.Shift => Operations.Multiply,
                    ConsoleKey.X => Operations.Multiply,
                    _ => throw new Exception("Ik weet niet wat je bedoelt")
                };
                Console.WriteLine();

                Console.WriteLine("Voer een nummer in zonder een komma.");
                var num_a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Voer nu nog een nummer in.");
                var num_b = Convert.ToInt32(Console.ReadLine());

                var result = operation switch
                {
                    Operations.Add => num_a + num_b,
                    Operations.Subtract => num_a - num_b,
                    Operations.Divide => (float)num_a / num_b,
                    Operations.Multiply => num_a * num_b,
                    _ => throw new Exception("Ik weet niet wat ik moet doen")
                };

                Console.WriteLine("Het antwoord is " + result);
                Console.WriteLine("Druk op (Y) om nog een keer iets te berekenen");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }

    public enum Operations
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
