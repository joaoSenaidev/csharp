// faca um programa que rode 10 vezes e pergunte o sexo das pessoas e pergunte tambem se ela gosta de esportes. ao final informe
// se a pessoa gosta de esportes


int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsporte = 0;
int qtdNaoEsporte = 0;

Console.Clear();

Console.WriteLine($"quantas pessoas tem na sua mesa?");
int qtdEntrevistados = int.Parse(Console.ReadLine()!);



for (int i = 1; i <= qtdEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }

    Console.WriteLine($"voce gosta de esportes? s/n");
    string Esporte = Console.ReadLine()!;

    if (Esporte == "s")
    {
        qtdEsporte++;
    }else{

        qtdNaoEsporte++;
    }

}

float percentual = (100 / qtdEntrevistados)*qtdEsporte;

Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"quantidade de Homem: {qtdHomem}");
Console.WriteLine($"Total de Entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"ToTal de pessoas que gostam de esporte: {qtdEsporte}");
Console.WriteLine($"ToTal de pessoas que nao gostam de esporte: {qtdNaoEsporte}");
Console.WriteLine($"percentual de pessoas que gostam de esporte: {percentual} %");




