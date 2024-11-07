using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int Idade { get; set; }

        public Aluno(string n, int m, int idd)
        {
            Nome = n;
            Matricula = m;
            Idade = idd;
        }

         public void ExibirDadosAL()
        {
            Console.WriteLine(@$"
            nome: {Nome};
            Matricula: {Matricula};
            Idade: {Idade};
            ");
        }
    }
}