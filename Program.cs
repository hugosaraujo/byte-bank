﻿using ByteBank;
using ByteBank.ContaCorrente;
using ByteBank.Titular;
using System.Reflection.Metadata;

try
{
    ContaCorrente conta = new ContaCorrente(0, "1528-X");

    /*
    conta.Sacar(25);
    Console.WriteLine(conta.GetSaldo());
    conta.Sacar(150);
    Console.WriteLine(conta.GetSaldo());
    */
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com número menor ou igual a zero. Tente Novamente...");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada!");
    Console.WriteLine("Saldo Insuficiente!");
    Console.WriteLine(ex. Message);
}

#region
//ContaCorrente contaDoJoel = new ContaCorrente();

//contaDoJoel.titular = "Joel Embiid";
//contaDoJoel.numeroAgencia = 1528;
//contaDoJoel.conta = "17568-2";
//contaDoJoel.saldo = 200;

//Console.WriteLine($"Titular: {contaDoJoel.titular}");
//Console.WriteLine($"Agência: {contaDoJoel.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoJoel.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoJoel.saldo)}");

//contaDoJoel.Depositar(500);

//Console.WriteLine();
//Console.WriteLine($"Titular: {contaDoJoel.titular}");
//Console.WriteLine($"Agência: {contaDoJoel.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoJoel.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoJoel.saldo)}");

//ContaCorrente contaDoHugo = new ContaCorrente();
//contaDoHugo.titular = "Hugo";
//contaDoHugo.numeroAgencia = 1927;
//contaDoHugo.conta = "276543-2";
//contaDoHugo.saldo = 100;

//Console.WriteLine();
//Console.WriteLine($"Titular: {contaDoHugo.titular}");
//Console.WriteLine($"Agência: {contaDoHugo.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoHugo.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoHugo.saldo)}");
//Console.WriteLine();

//contaDoHugo.Depositar(500);

//Console.WriteLine($"Titular: {contaDoHugo.titular}");
//Console.WriteLine($"Agência: {contaDoHugo.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoHugo.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoHugo.saldo)}");
//Console.WriteLine();

//if (contaDoHugo.Sacar(100) == true)
//{
//    Console.WriteLine("Saque realizado com sucesso!!");
//    Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoHugo.saldo)}");
//}
//else
//{
//    Console.WriteLine("Saldo indisponível!");
//}

//contaDoHugo.Transferir(125, contaDoJoel);

//Console.WriteLine($"Titular: {contaDoHugo.titular}");
//Console.WriteLine($"Agência: {contaDoHugo.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoHugo.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoHugo.saldo)}");
//Console.WriteLine();

//Console.WriteLine($"Titular: {contaDoJoel.titular}");
//Console.WriteLine($"Agência: {contaDoJoel.numeroAgencia}");
//Console.WriteLine($"Número de Conta: {contaDoJoel.conta}");
//Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoJoel.saldo)}");

//ContaCorrente contaDoFelipe = new ContaCorrente();
//contaDoFelipe.titular = "Felipe K. Pinto";
//contaDoFelipe.numeroAgencia = 1396;
//contaDoFelipe.conta = "897654-2";

//contaDoFelipe.Depositar(1000);

//Console.WriteLine($"Saldo: R$ {string.Format("{0:00.00}", contaDoFelipe.saldo)}");


//Cliente cliente = new Cliente();
//cliente.nome = "Gabriel Garcia Marquez";
//cliente.cpf = "893.726.511-08";
//cliente.profissao = "Escritor";

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = cliente;
//conta1.numeroAgencia = 1528;
//conta1.conta = "891234-0";

//cliente.ExibirInfoCliente();
//Console.WriteLine("Saldo: " + conta1.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Rina Sawayama";
//conta2.titular.cpf = "923.927.047-04";
//conta2.titular.profissao = "Cantora";
//conta2.numeroAgencia = 1829;
//conta2.conta = "1010-2";

//conta2.Depositar(900);

//Console.WriteLine( );
//Console.WriteLine("Nome: " + conta2.titular.nome);
//Console.WriteLine("Saldo: " + conta2.saldo);

//ContaCorrente conta4 = new ContaCorrente();

//conta4.Titular = new Cliente();
//conta4.Titular.Nome = "Rosalia";
//conta4.Titular.Cpf = "932.778.238-04";
//conta4.Titular.Profissao = "Cantora";
//conta4.Agencia = 2798;
//conta4.Conta = "2020-X";

//conta4.ExibirInfoConta();


//Console.WriteLine($"{Cliente.ClientesCadastrados}");

//ContaCorrente conta6 = new ContaCorrente(1920, "20204-X");
//conta6.Titular = new Cliente();

//Console.WriteLine($"{Cliente.ClientesCadastrados}");

//ContaCorrente conta7 = new ContaCorrente(2001, "90903-X");
//conta7.Titular = new Cliente();

//Console.WriteLine($"{Cliente.ClientesCadastrados}");

//ContaCorrente conta5 = new ContaCorrente(1829, "189001-2");

//conta5.Titular = new Cliente("Solana Imani Rowe", "909.808.421-04", "Cantora");

//Console.ReadLine();
#endregion
#region
//void infoUsuario()
//{
//    Cliente ah = new Cliente("Alana Haim", "5555982", "Cantora");
//    Console.WriteLine(ah.ToString());


//}
#endregion
