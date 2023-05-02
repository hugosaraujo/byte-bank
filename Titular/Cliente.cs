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
        public static int ClientesCadastrados { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string Nome, string Cpf, string Profissao) 
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Profissao = Profissao;

            ClientesCadastrados++;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, \n" +
                   $"CPF: {this.Cpf}, \n" +
                   $"Profissao: {this.Profissao}, \n";
        }
    }
}
