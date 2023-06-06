using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {
        int num;
        bool Invalid = false;

        do
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out num) || num < 1 || num > 10)
            {
                Console.WriteLine("Número inválido. Tente novamente, com valores de 1 a 10.");
            }
            else
            {
                Invalid = true;
            }

        } while (!Invalid);
        Console.WriteLine("Você digitou: " + num + ".");

        Console.WriteLine("Deseja digitar um novo número? (S/N): ");
        string repeatInput = Console.ReadLine();

        repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
        }
    }
}
    
