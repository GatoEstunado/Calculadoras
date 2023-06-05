using System;
using System.Globalization;
//Ohata
class Program
{
    static void Main()
    {
        char op;
        float num1, num2;

        bool exit = false;
        while (!exit)
        {

            Console.WriteLine("Introduza o operador (+, -, *, /):  ");
            op = Console.ReadLine()[0];

            if (op == 'N')
            {
                break;
            }

            Console.WriteLine("Introduza os valores: ");
            string[] inputValues = Console.ReadLine().Split(' ');
            num1 = float.Parse(inputValues[0]);
            num2 = float.Parse(inputValues[1]);


            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Operador inválido, introduza um valor válido: +, -, *, /.");
                    break;
            }

            Console.WriteLine("Deseja continuar? S/N");
            char decision = Console.ReadLine()[0];
            if (decision == 'N')
            {
                exit = true;
            }
        }

    }
}
