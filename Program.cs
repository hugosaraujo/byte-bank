using ByteBank;

ContaCorrente ContaDoHugo = new ContaCorrente();

ContaDoHugo.titular = "Hugo";
ContaDoHugo.conta = "155464-2";
ContaDoHugo.agencia = "1564";
ContaDoHugo.saldo = 0.00;

ContaDoHugo.Depositar(250);

Console.WriteLine("O saldo atual da sua conta é R$" + ContaDoHugo.saldo);

