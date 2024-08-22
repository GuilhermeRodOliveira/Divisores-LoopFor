using System;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Faça um programa que peça ao usuário para inserir um número e, em seguida, imprima todos os divisores desse número usando um loop for.
            //Acresentar se o nuermo for primo.
            Console.WriteLine("Digite um número para descobri seus divisores. ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divisores de {num} :");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
