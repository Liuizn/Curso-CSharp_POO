using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_modulo5
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string NumTitular { get; set; }
        public double Saldo { get; private set; } 


        public Conta (int numConta, string numTitular)
        {
            NumConta = numConta; 
            NumTitular = numTitular;
            Saldo = 0;
        }

        public Conta (int numConta, string numTitular, double saldo) : this (numConta, numTitular)
        {
            Saldo = saldo;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5;
        }


        public override string ToString()
        {
            return "Numéro da Conta: "
                + NumConta
                + ", Titular da Conta: "
                + NumTitular
                + ", Saldo Atual: "
                + Saldo.ToString("F2");
        }
    }
}
