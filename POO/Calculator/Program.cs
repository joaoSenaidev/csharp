using Calculator.Classes;

Calculadora Calc = new Calculadora();

Calc.Numero1 = 0;
Calc.Numero2 = 0;

Console.Clear();

Console.WriteLine($"Bem-vindo a Calculadora do JoaoP");
Console.WriteLine($"Digite um numero:");
Calc.Numero1 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o segundo numero:");
Calc.Numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine();

Calc.Somar(0);
Calc.subtrair(0);
Calc.Dividir(0);
Calc.multiplicar(0);

// Console.WriteLine($"{Calc.Somar(0)}");
// Console.WriteLine($"{Calc.subtrair(0)}");
// Console.WriteLine($"{Calc.Dividir(0)}");
// Console.WriteLine($"{Calc.multiplicar(0)}");







