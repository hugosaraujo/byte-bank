using ByteBank.ContaCorrente;

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


ContaCorrente contaDoFelipe = new ContaCorrente();
contaDoFelipe.titular = "Felipe K. Pinto";
contaDoFelipe.numeroAgencia = 1396;
contaDoFelipe.conta = "897654-2";

contaDoFelipe.Depositar(1000);

Console.WriteLine($"Saldo: R$ {string.Format("{0:00.00}", contaDoFelipe.saldo)}");

Console.ReadLine();