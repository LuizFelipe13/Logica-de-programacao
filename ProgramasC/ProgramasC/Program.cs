using System;

namespace ProgramasC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma, multiplicacao;
            Console.WriteLine("Informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            multiplicacao = soma * num1;

            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
        }
    }
}
