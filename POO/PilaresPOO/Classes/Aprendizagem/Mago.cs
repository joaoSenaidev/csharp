using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes
{
    public  class Mago : Personagem
    {
        public string? Cajado { get; set; }
        
        
        public override void Atacar()
        {
            Console.WriteLine($"O mago lança o seu feitiço com o seu {Cajado}!🧙‍♂️");
            
        }

    }
}