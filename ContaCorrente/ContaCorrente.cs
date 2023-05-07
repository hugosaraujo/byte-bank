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
        public static int TotalDeContas { get; private set; }
        public static decimal TaxaOperacao { get; set; }
        public int Agencia { get; set; }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        public decimal saldo = 100;
        

        public ContaCorrente(int Agencia, string Conta)
        {
            this.Agencia = Agencia;
            this.Conta = Conta;
            
            try 
            {
                TaxaOperacao = 30 / TotalDeContas;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Ocorreu um erro. Não é possível fazer uma divisão com o divisor zero");
            }
            
            TotalDeContas++;
        }

        public string ExibirInfoConta() 
        {
            return $"Titular: {this.Titular.Nome}" +
                   $"Agência: {this.Agencia}" +
                   $"Número de Conta: {this.Conta}" +
                   $"Saldo: R$ {String.Format("{0:00.00}", this.saldo)}";
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
