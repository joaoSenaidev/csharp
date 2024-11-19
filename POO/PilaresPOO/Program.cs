using PilaresPOO.Pilares;

ContaCorrente ctJoao = new ContaCorrente();
ctJoao.Titular = "Joao Pedro de Oliveira Cruz";
ctJoao.Depositar(1400f);


Console.Clear();
Console.WriteLine($"Titular da Conta: {ctJoao.Titular}");
Console.WriteLine($"Saldo inicial da Conta: R${ctJoao.getSaldo()}");

float valorSacado = ctJoao.Sacar(800f);

Console.WriteLine($"Seu saque foi de:{valorSacado}");
Console.WriteLine($"Novo saldo da Conta: R${ctJoao.getSaldo()}💵");

