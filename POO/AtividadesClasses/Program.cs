using AtividadesClasses.Classes;

Veiculo carro = new Veiculo();

Console.WriteLine($"Qual e a marca?");
carro.marca = Console.ReadLine();

Console.WriteLine($"Qual e o modelo?");
carro.modelo = Console.ReadLine();

Console.WriteLine($"Qual e a cor?");
carro.cor = Console.ReadLine();

Console.WriteLine($"Qual e a sua potencia? ");
carro.potencia = Console.ReadLine();

Console.WriteLine($"Quantas portas?");
carro.qtdPortas = int.Parse(Console.ReadLine());

Console.WriteLine(@$"carro: {carro.marca} {carro.modelo}");

carro.Ligar();
carro.Acelerar();
carro.Desligar();
carro.Freiar();
