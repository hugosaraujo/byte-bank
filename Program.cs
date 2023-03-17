using ByteBank;

ContaCorrente contaDoHugo = new ContaCorrente();

contaDoHugo.titular = "Hugo";
contaDoHugo.conta = "155464-2";
contaDoHugo.agencia = "1564";
contaDoHugo.saldo = 0.00;

contaDoHugo.Depositar(250);

contaDoHugo.ExibirDadosConta();

ContaCorrente contaDoZam = new ContaCorrente();
contaDoZam.titular = "Zam-Zam";
contaDoZam.conta = "182838-0";
contaDoZam.agencia = "13298";

contaDoZam.ExibirDadosConta();

contaDoZam.Depositar(400);
contaDoZam.Transferir(200, contaDoHugo);

contaDoHugo.ExibirDadosConta();
contaDoZam.ExibirDadosConta();

ContaCorrente contaDaSelena = new ContaCorrente();

contaDaSelena.titular = "Selena Gomez";
contaDaSelena.conta = "77773-6";
contaDaSelena.conta = "1328";

contaDaSelena.ExibirDadosConta();
contaDoHugo.ExibirDadosConta();

contaDoHugo.Transferir(300, contaDoZam);

contaDoHugo.ExibirDadosConta();
contaDaSelena.ExibirDadosConta();

Console.ReadLine();