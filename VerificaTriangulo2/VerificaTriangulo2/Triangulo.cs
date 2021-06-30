using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaTriangulo2
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void VerificaTriangulo()
        {
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
                Console.WriteLine("Forma um triângulo");
            else
                Console.WriteLine("Não forma um triângulo");
        }
    }
}
