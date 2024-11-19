using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes
{
    public class Arqueiro : Personagem
    {
        public string? Arco { get; set; }
        
         public override void Atacar()
         {
            Console.WriteLine($"O arqueiro deu um dano com sua flecha jogada!🏹");
            
         }
        
    }
}