using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Pilares
{
    public abstract class Conta
    {
        protected float Saldo { get; set; }
        public string? Titular { get; set; }

        public abstract float Sacar(float valor);

        public abstract bool Depositar(float valor);
        
        //devolve o saldo da conta
        public float getSaldo ()
        {
            return Saldo;
        }
    }
}