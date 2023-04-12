using ByteBank.ContaCorrente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public void ExibirInfoCliente ()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Profissão: " + Profissao);
        }
    }
}
