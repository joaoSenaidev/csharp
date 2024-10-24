// Faça um programa que carregue 1 array tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.


int[] numeros = new int[6];
int par = 0;
int impar = 0;



for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Insira um numero");
    int numeroDigitados = int.Parse(Console.ReadLine()!);

    if (numeroDigitados % 2 == 0)
    {
        par++;

    }
    else
    {
        impar++;
    }

}






