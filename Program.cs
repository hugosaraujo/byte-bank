using ByteBank.ContaCorrente;

ContaCorrente contaDoJoel = new ContaCorrente();

contaDoJoel.titular = "Joel Embiid";
contaDoJoel.numeroAgencia = 1528;
contaDoJoel.conta = "17568-2";
contaDoJoel.saldo = 200;

Console.WriteLine($"Titular: {contaDoJoel.titular}");
Console.WriteLine($"Agência: {contaDoJoel.numeroAgencia}");
Console.WriteLine($"Número de Conta: {contaDoJoel.conta}");
Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoJoel.saldo)}");

contaDoJoel.Depositar(500);


Console.WriteLine();
Console.WriteLine($"Titular: {contaDoJoel.titular}");
Console.WriteLine($"Agência: {contaDoJoel.numeroAgencia}");
Console.WriteLine($"Número de Conta: {contaDoJoel.conta}");
Console.WriteLine($"Saldo: R$ {String.Format("{0:00.00}", contaDoJoel.saldo)}");


Console.ReadLine();