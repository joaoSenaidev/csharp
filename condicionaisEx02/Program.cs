using System.Data.Common;

Console.WriteLine($"Digite o placar do Time1");
int Time1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o placar do Time2");
int Time2 = int.Parse(Console.ReadLine()!);

if (Time1 > Time2)
{
    Console.WriteLine($"O Time1 venceu!!");

}
else if (Time1 < Time2)
{
    Console.WriteLine($"O Time2 venceu!!");

}
else
{
    Console.WriteLine($"O resultado foi empate!!");
}

