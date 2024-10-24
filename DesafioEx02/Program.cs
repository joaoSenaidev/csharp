// Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.

int Mulher = 0;
int Homem = 0; 
float idadeMulher = 0;
float idadeHomem = 0;

Console.WriteLine($"quantas pessoas na mesa?");
int Pessoas = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= Pessoas; i++)
{
    Console.WriteLine($"Pessoa {i}");
    

    Console.WriteLine($"Qual sua idade?");
    int idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Qual o seu peso?");
    int peso = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Qual o seu sexo?");
    string sexo = Console.ReadLine()!;
    
    if (sexo == "m")
    {
        Homem++;
        idadeHomem += idade;
    }
    else
    {
        Mulher++;
        idadeMulher += idade;
    }
    
}

    float mediaHomem = (idadeHomem / Homem);
    float mediaMulher = (idadeMulher / Mulher);

Console.WriteLine($"Total de homens: {Homem}");
Console.WriteLine($"Total de homens: {Mulher}");
Console.WriteLine($"A media de idade de homens é: {mediaHomem}");
Console.WriteLine($"A media de idade de Mulheres é: {mediaMulher}");

