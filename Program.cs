// Bibliotecas
using System;
using System.Globalization;

// Classe Programa
class Program
{
    // Programa para a operação de Soma
    static int Soma(int a, int b)
    {
        // Retornar os valores de 'a' e 'b'
        return a + b;
    }

    // Programa para a operação de Subtração
    static int Sub(int a, int b)
    {
        // Retornar os valores de 'a' e 'b'
        return a - b;
    }

    // Programa para a operação de Divisão
    static int Dividir(int a, int b)
    {
        // Retornar os valores de 'a' e 'b'
        return a / b;
    }

    // Programa para a operação de Multiplicação
    static int Mult(int a, int b)
    {
        // Retornar os valores de 'a' e 'b'
        return a * b;
    }

    // Programa principal
    static void Main()
    {
        // Booleano para inserir o loop
        bool exit = false;
        while (!exit)
        {
            // Interface do usuário, para alocar os dois valores, ou parar a execução do programa
            Console.WriteLine("Digite dois numeros ou 'N' para parar: ");
            // Ler e receber os valores
            string input = Console.ReadLine();

            // Se o valor recebido for igual a 'N', encerrar
            if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
            {
                // Saída
                exit = true;
                continue;
            }

            // Dividir a entrada em dois números
            string[] numbers = input.Split(' ');
            
            // Se o os valores inforamados serem mais de 2
            if (numbers.Length != 2)
            {
                // Interface para caso o valor seja inválido
                Console.WriteLine("Valor inválido. Tente novamente separado por espaço.");
                continue;
            }

            // Váriaveis 'a' e 'b'
            int a, b;
            // Receber os valores 'a' e 'b' através de PARSE
            if (!int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b))
            {
                // Interface do usuário para um valor inválido
                Console.WriteLine("Valor inválido. Tente novamente.");
                continue;
            }

            // Interface para entregar a conta de cada uma das operações
            Console.WriteLine("Soma: " + Soma(a, b));
            Console.WriteLine("Subtracao: " + Sub(a, b));
            Console.WriteLine("Divisao: " + Dividir(a, b));
            Console.WriteLine("Multiplicacao: " + Mult(a, b));

            Console.WriteLine();
        }
    }
}


            
