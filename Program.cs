using ByteBank.ContaCorrente;

ContaCorrente contaDoJoel = new ContaCorrente();

contaDoJoel.titular = "Joel Embiid";
contaDoJoel.numeroAgencia = 1528;
contaDoJoel.conta = "17568-2";
contaDoJoel.saldo = 200;

Console.WriteLine("Saldo da conta do Joel: " + contaDoJoel.saldo);
Console.ReadLine();