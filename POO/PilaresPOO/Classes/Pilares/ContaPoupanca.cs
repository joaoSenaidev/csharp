using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Pilares
{
    public class ContaPoupanca : Conta
    {
        public int LimiteSaque { get; set; }
        public int Rendimento { get; set; }
        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}