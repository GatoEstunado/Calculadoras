// Bibliotecas
using System;
using System.Globalization;

// Classe Program
class Program
{
  // Programa principal
    static void Main()
    {
        // Booleano para inserir looping
        bool repeat = true;

        // Equanto os requisitos se cumprirem, repetir
        while (repeat)
        {
            // Váriavel 'num'
            int num;

            // Interface do usuário para digitar um número positivo
            Console.Write("Digite um numero inteiro positivo: ");
            // Ler e receber o valor dado pelo usuário 
            num = int.Parse(Console.ReadLine());

            // Interface do usuário, para apresentar os resultados
            Console.Write("Os primeiros " + num + " números pares são: ");

            // Loop, váriavel 'i' igual a 2
            // Loop continua enquanto 'i' for menor ou igual a 'num' * 2
            // Sempre adiciona a 'i' + 2
            for (int i = 2; i <= num * 2; i += 2)
            {
                // Dar espaçamento entre os valores
                Console.Write(i + " ");
            }

            Console.WriteLine();
          
            // Interface do usuário, para repetir ou encerrar a execução
            Console.Write("Deseja repetir o processo? (S/N): ");
            // Ler e receber a resposta
            string repeatInput = Console.ReadLine();
            // Caso a resposta seja igual a 'S' ou 's', repetir
            repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
        }
    }
}
