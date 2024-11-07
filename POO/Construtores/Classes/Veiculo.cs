using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veiculo
    {

        public string? Marca;
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public string? Cor { get; set; }

        // Metodos construtures (Metodos especiais que nao retornam valor)
        public Veiculo(string ma, string md, int an, string cr)
        {
            Marca = ma;
            Modelo = md;
            Ano = an;
            Cor = cr;
        }


        public void ExibirDados()
        {
            Console.WriteLine(@$"
            Marca: {Marca};
            Modelo: {Modelo};
            Ano: {Ano};
            Cor: {Cor};
            ");
        }

    }
}