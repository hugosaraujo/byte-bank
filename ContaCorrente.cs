using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public string titular;
        public string conta;
        public string agencia;
        public double saldo = 100; 

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool Sacar(double valor)
        {   
            if (valor <= this.saldo) {
                this.saldo -= valor;
                return true;
            } else {
                return false; 
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor) {
                return false; 
            } else {
                this.Sacar(valor);
                destino.Depositar(valor); 
                return true;
            }
        }
        public void ExibirDadosConta() 
        {
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("Numero Agência: " + this.agencia);
            Console.WriteLine("Saldo:" + this.saldo);
        }
    }
}
