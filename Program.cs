// Bibliotecas
using System;
using System.Globalization;

// Classe Program
class Program
{
    // Programa principal
    static void Main()
    {
        // Váriaveis
        char op;
        float num1, num2;

        // Booleano para o looping
        bool exit = false;
        while (!exit)
        {
            // Interface do usuário para colocar o operador
            Console.WriteLine("Introduza o operador (+, -, *, /):  ");
            // Ler e receber o operador dado pelo usuário
            op = Console.ReadLine()[0];

            // IF com a condição de parar o programa
            if (op == 'N' || op == 'n')
            {
                break;
            }

            // Interface para o usuário colocar os valores
            Console.WriteLine("Introduza os valores, separados por espaco: ");
            // Ler e receber os valores dados pelo usuário, com PARSE para receber dois valores separados
            string[] inputValues = Console.ReadLine().Split(' ');
            num1 = float.Parse(inputValues[0], CultureInfo.InvariantCulture);
            num2 = float.Parse(inputValues[1], CultureInfo.InvariantCulture);

            // SWITCH para alocar a multiplas operações matemáticas, + - * /
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

                // DEFAULT para caso o operador seja inválido
                default:
                    Console.WriteLine("Operador invalido, introduza um valor valido: +, -, *, /.");
                    break;
            }

            // Loop para executar o programa novamente, ou encerrar
            // Interface do usuário
            Console.WriteLine("Deseja continuar? S/N");
            //Receber a resposta
            char decision = Console.ReadLine()[0];
            // Se a resposta for igual a 'N' ou 'n', encerrar
            if (decision == 'N' || decision == 'n')
            {
                exit = true;
            }
        }
    }
}
