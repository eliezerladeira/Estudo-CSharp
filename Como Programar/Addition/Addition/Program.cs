// Um programa de soma

using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber,   // primeira string fornecida pelo usuário
                   secondNumber;  // segunda string fornecida pelo usuário

            int number1,          // primeiro número a somar
                number2,          // segundo número a somar
                sum;              // soma de number1 e number2

            // solicita e lê o primeiro número do usuário como string
            Console.Write("Please enter the first integer: ");
            firstNumber = Console.ReadLine();

            // lê o segundo número do usuário como string
            Console.Write("\nPlease enter the second integer: ");
            secondNumber = Console.ReadLine();

            // converte números de tipo string para tipo int
            number1 = Int32.Parse(firstNumber);
            number2 = Int32.Parse(secondNumber);

            // soma os números
            sum = number1 + number2;

            // exibe o resultado
            Console.WriteLine("\nThe sum is {0}.", sum););
        } // fim do método Main
    } // fim da classe Addition
}