using ByteBank;

ContaCorrente contaDoHugo = new ContaCorrente();

contaDoHugo.titular = "Hugo";
contaDoHugo.conta = "155464-2";
contaDoHugo.agencia = "1564";
contaDoHugo.saldo = 0.00;

contaDoHugo.Depositar(250);

Console.WriteLine("O saldo atual da sua conta é R$" + contaDoHugo.saldo);

ContaCorrente contaDoZam = new ContaCorrente();
contaDoZam.titular = "Zam-Zam";
contaDoZam.conta = "182838-0";
contaDoZam.agencia = "13298";

Console.WriteLine("O saldo atual da sua conta é R$" + contaDoZam.saldo);

contaDoZam.Depositar(400);
contaDoZam.Transferir(200, contaDoHugo);

Console.WriteLine("O saldo atual da sua conta é R$" + contaDoHugo.saldo);
Console.WriteLine("O saldo atual da sua conta é R$" + contaDoZam.saldo);

ContaCorrente contaDaSelena = new ContaCorrente();
contaDaSelena.titular = "Selena Gomez";
contaDaSelena.conta = "77773-6";
contaDaSelena.conta = "1328";

Console.WriteLine("O saldo atual da sua conta é R$" + contaDaSelena.saldo);

contaDoHugo.Transferir(300, contaDaSelena);

Console.WriteLine("O saldo atual da sua conta é R$" + contaDoHugo.saldo);
Console.WriteLine("O saldo atual da sua conta é R$" + contaDaSelena.saldo);

contaDoHugo.Transferir(300, contaDoZam);
Console.WriteLine("O saldo atual da sua conta é R$" + contaDoHugo.saldo);

Console.ReadLine();