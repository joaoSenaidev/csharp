// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados


int qtdMulher = 0;
int qtdHomem = 0;
int qtdProduto = 0;
int qtdNaoGostouProduto = 0;

    Console.WriteLine($"Qual o seu nome?");
    string nome = Console.ReadLine()!;
    

    Console.WriteLine($"Quantas pessoas estao com voce? ");
    int Entrevistados = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= Entrevistados; i++)
{
   Console.WriteLine($"Qual o seu sexo? (m/f)");
   string sexo = Console.ReadLine()!;
    
    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }

    Console.WriteLine($"Voce gostou do produto? (s/n)");
    string Produto = Console.ReadLine()!;

    if (Produto == "s")
    {
        qtdProduto++;
    }
    else
    {
        qtdNaoGostouProduto++;
    }
    
}

float percentual = (100 / qtdHomem)*qtdProduto;

Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"quantidade de Homem: {qtdHomem}");
Console.WriteLine($"Total de Pessoas entrevistadas: {qtdMulher + qtdHomem}");
Console.WriteLine($"Total de Pessoas que disseram sim: {qtdProduto}");
Console.WriteLine($"Total de Pessoas que disseram nao: {qtdNaoGostouProduto}");
Console.WriteLine($"Total de mulheres que disseram sim: {qtdProduto}");
Console.WriteLine($"percentual de homens que disseram nao: {percentual} %");