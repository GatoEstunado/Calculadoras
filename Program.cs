using System;
using System.Globalization;
class Program
{
    static int Soma(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static int Dividir(int a, int b)
    {
        return a / b;
    }

    static int Mult(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Digite dois números ou N/n para parar: ");
            string input = Console.ReadLine();

            if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
            {
                exit = true;
                continue;
            }

            string[] numbers = input.Split(' ');
            
            if (numbers.Length != 2)
            {
                Console.WriteLine("Valor inválido. Tente novamente separado por espaço.");
                continue;
            }

            int a, b;
            if (!int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                continue;
            }

            Console.WriteLine("Soma: " + Soma(a, b));
            Console.WriteLine("Subtração: " + Sub(a, b));
            Console.WriteLine("Divisão: " + Dividir(a, b));
            Console.WriteLine("Multiplicação: " + Mult(a, b));

            Console.WriteLine();
        }
    }
}


            