using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string? Nome { get; set; }
        public int Lancamento { get; set; }
        public string? Genero { get; set; }
        public float Preco { get; set; }

        public Jogo(string nm, int lc, string gr, float prc)
        {
            Nome = nm;
            Lancamento = lc;
            Genero = gr;
            Preco = prc;
        }

        public void ExibirDadosJG()
        {
            Console.WriteLine(@$"
            Nome: {Nome};
            Lancamento: {Lancamento};
            Genero: {Genero};
            Preco: {Preco};
            ");
        }


    }
}