using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class ContaCorrente
    {
        public int Agencia { get; set; }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        private decimal saldo=100; 


        public void ExibirInfoConta() 
        {
            Console.WriteLine($"Titular: {this.Titular.Nome}");
            Console.WriteLine($"Agência: {this.Agencia}");
            Console.WriteLine($"Número de Conta: {this.Conta}");
            Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", this.saldo)}");
        }
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
