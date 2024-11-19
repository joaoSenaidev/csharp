using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes
{
    public class PowerGeneric : Personagem
    {
        // Nao tem o metodo atacar, ele usa o metodo do pai
        public override void Atacar()
        {
            Console.WriteLine($"O personagem esta atacando!");
            
        }
    }
}