// string carro1;
// string carro2;
// string carro3;

// cria um array tamanho 3 (0 a 2)
string[] carros = new string [3]; //Array tamanho 3 - vazio 


Console.Clear();
Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[0] = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[1] = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[2] = Console.ReadLine()!;

Console.WriteLine($"O carro cadastrado é {carros[0]}, {carros[1]}, {carros[2]}");
