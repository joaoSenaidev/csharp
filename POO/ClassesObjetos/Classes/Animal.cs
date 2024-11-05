using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Animal
    {
        public string Raca;
        public string cor;
        public string nome;
        public int idade = 0;

        public void FazerBarulho(string barulho = "Barulho Genérico")
        {
            Console.WriteLine($"som do animal: {barulho}");

        }

        public void Envelhecer()
        {

            idade = idade + 1;
        }
    }
}