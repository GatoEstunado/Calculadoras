// Bibliotecas
using System;
using System.Globalization;

// Classe Program
class Program
{
    // Programa pricipal
    static void Main()
    {
        // Booleano para o looping
        bool repeat = true;
        while (repeat)
        {
            
        // Váriaveis
        int num;
        bool Invalid = false;

        // DO, para executar os seguintes comando enquanto cumprir seus requisitos
        do
        {
            // Interface do usuário para inserir um número
            Console.WriteLine("Digite um numero de 1 a 10: ");
            // Ler e receber os valores
            string input = Console.ReadLine();

            // IF para que se o número dado for menor que 1 e maior que 10, dar a mensagem
            if (!int.TryParse(input, out num) || num < 1 || num > 10)
            {
                // Interface de número inválido
                Console.WriteLine("Numero invalido. Tente novamente, com valores de 1 a 10.");
            }
            // ELSE para caso o número seja válido, prossiga
            else
            {
                Invalid = true;
            }
        }
        // WHILE, Enquanto cumprir os requisitos (true)
        while (!Invalid);
        // Interface do usuário
        Console.WriteLine("Voce digitou: " + num + ".");

        // Loop para repetir o processo
        Console.WriteLine("Deseja digitar um novo numero? (S/N): ");
        // Receber a resposta
        string repeatInput = Console.ReadLine();

        // Se a resposta for igual a 'S' ou 's', repetir
        repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
        }
    }
}
    
