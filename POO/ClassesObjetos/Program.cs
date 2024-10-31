//importando as classes de dentro da pasta Classes.
using ClassesObjetos.Classes;

//cria o objeto animal
Animal cachorro = new Animal ();

cachorro.nome = "Snoop";
cachorro.Raca = "Border collie";
cachorro.cor = "Preto com Branco";
cachorro.idade = 7;

Animal gato = new Animal();

gato.nome = "Adolfinho";
gato.cor = "Marrom";
gato.Raca = "Scottish Fold";
gato.idade = 4;



Console.Clear();

Console.WriteLine($"Nome do Cachorrinho: {cachorro.nome}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Raça do {cachorro.nome}: {cachorro.Raca}");

Console.WriteLine();


Console.WriteLine($"Nome do Gatinho: {gato.nome}");
Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");
Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
Console.WriteLine($"Raça do {gato.nome}: {gato.Raca}");


