Console.WriteLine($"informe seu salario");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"informe o valor gasto");
float gasto = float.Parse(Console.ReadLine()!);


if (salario > gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{

    Console.WriteLine($"Orçamento estourado!");
}


