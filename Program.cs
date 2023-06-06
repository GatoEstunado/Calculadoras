// Bibliotecas
using System;
using System.Globalization;

// Classe Program
class Program
{
    // Programa principal
    static void Main()
    {
        // Booleanp para inserir o loop
        bool repeat = true;

        // Enquanto os requisitos se cumprirem, repetir
        while (repeat)
        {
            // Váriavel 'num'
            int num;
            
            // Interface do usuário, para inserer um número
            Console.WriteLine("Digite um numero positivo inteiro: ");

            // Se o número for igual ou menor que 0, dar a mensagem de inválido
            if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                // Mensagem caso o número dado seja inválido
                Console.WriteLine("Numero invalido. Tente novamente.");
                continue;
            }

            // Declarar o 'i' e dar ele como '= 1'
            int i = 1;

            // Enquanto a váriavel 'i' for igual ou maior que 1
            while (i <= num)
            {
                // Dar os valores da seguinte forma, 1 + 1 (i + i), separados por espaço, até chegar no valor forncecido
                Console.Write(i + " ");
                i++;
            }
            
            Console.WriteLine();

            // Interface do usuário para repetir o processo ou encerrar a execução 
            Console.WriteLine("Deseja repetir o processo? (S/N): ");
            // Receber a resposta
            string repeatInput = Console.ReadLine();
            // Se a resposta for igual a 'S' ou 's' repetir
            repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
        }
    }
}
