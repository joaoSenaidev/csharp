using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculadora
    {
        public float Numero1;
        public float Numero2;

        public void Somar(float Resultado)
        {
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"soma:{Resultado}");
            
        }

        public void Dividir(float Resultado)
        {
            Resultado = Numero1 / Numero2;
            Console.WriteLine($"dividir:{Resultado}");
            
        }

        public void subtrair(float Resultado)
        {
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"subtrair:{Resultado}");
            
        }

        public void multiplicar(float Resultado)
        {
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"multiplicar:{Resultado}");
            
        }
    }

}