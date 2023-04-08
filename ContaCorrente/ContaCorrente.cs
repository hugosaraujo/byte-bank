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
        public bool Sacar(decimal valor) 
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else 
            {
                return false;
            }   
        }

        public bool Transferir(decimal valor, ContaCorrente destino)
        { 
            if (this.saldo < valor)
            {
                return false; 
            }
            else 
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true; 
            }
        }
    }
}
