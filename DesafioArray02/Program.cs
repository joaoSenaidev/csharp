// Faça um programa que carregue dois vetores de 10 elementos numéricos cada um e imprima a intercalação desses dois

int[] arraysNumericos1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arraysNumericos2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

for (int i = 0; i <= arraysNumericos1.Length; i++)
{
    if (i % 2 == 0)
    {


        Console.WriteLine(arraysNumericos1[i]);


    }
    else
    {

        Console.WriteLine(arraysNumericos2[i]);


    }

}

