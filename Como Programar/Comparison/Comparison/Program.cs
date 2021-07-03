// Usando instruções if, operadores relacionais e operadores de igualdade

using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,     // primeiro número a comparar
                number2;     // segundo número a comparar

            // lê o primeiro número do usuário
            Console.Write("Please enter first integer: ");
            number1 = Int32.Parse(Console.ReadLine());

            // lê o segundo número do usuário
            Console.Write("\nPlease enter second integer: ");
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine(number1 + " == " + number2);

            if (number1 != number2)
                Console.WriteLine(number1 + " != " + number2);

            if (number1 < number2)
                Console.WriteLine(number1 + " < " + number2);

            if (number1 > number2)
                Console.WriteLine(number1 + " > " + number2);

            if (number1 <= number2)
                Console.WriteLine(number1 + " <= " + number2);

            if (number1 >= number2)
                Console.WriteLine(number1 + " >= " + number2);
        } // fim do método Main
    } // fim da classe Comparison
}
