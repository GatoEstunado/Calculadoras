using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {

            int num, i = 1;

            Console.WriteLine("Digite um número positivo inteiro: ");
            num = int.Parse(Console.ReadLine());


            while (i <= num)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("Deseja repetir o processo? (S/N): ");
            string repeatInput = Console.ReadLine();
            repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
        }
    }
}
