int qtdMulher = 0;
int qtdHomem = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if(sexo == "f")
    { 
        qtdMulher++ ;
    }
    else
    {
        qtdHomem++;
    }

}

Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"quantidade de mulheres: {qtdHomem}");





