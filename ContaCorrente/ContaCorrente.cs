using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public decimal saldo; 

        public void Depositar(decimal valor) 
        {
            this.saldo += valor;
        }
    }
}
