string[] carros = new string[3];

Console.Clear();

for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine($"Insira o primeiro carro:");
    carros[i] = Console.ReadLine()!;

}

Console.WriteLine($"O carro cadastrado e: {carros[0]}, {carros[1]}, {carros[2]}");
