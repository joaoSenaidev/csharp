using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadesClasses
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public string cor;
        public string potencia;
        public int qtdPortas;

        public void Acelerar()
        {
            Console.WriteLine($"seu carro esta: {Acelerar}");

        }

        public void Ligar()
        {
            Console.WriteLine($"{marca} {modelo} ligando");

        }

        public void Desligar()
        {
            Console.WriteLine($"{modelo} desligando");


        }

        public void Freiar()
        {
            Console.WriteLine($"{modelo} Freiando:");

        }
    }
}