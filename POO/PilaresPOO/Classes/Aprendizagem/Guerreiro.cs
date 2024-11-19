using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes
{
    public class Guerreiro : Personagem
    {
        public string? Espada { get; set; }
        
        
        public override void Atacar()
        {
            Console.WriteLine($"O Gurreiro deu um dano critico com a sua {Espada}!⚔️");
            
        }
    }
}