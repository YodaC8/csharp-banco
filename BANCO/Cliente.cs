using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
         this.saldo += valor;
         }
        public void Debitar(double valor)
        {
        this.saldo -= valor;
        }
    }
}
