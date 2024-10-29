// Faça um programa que receba a temperatura média de cada mês do ano e armazene essas temperaturas em um vetor. Calcule e imprima a maior e a menor temperatura do ano.

float[] temperatura = new float[12];
string[] meses = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro" };

Console.Clear();

for (int i = 0; i < temperatura.Length; i++)
{
    Console.WriteLine($"Digite a temperatura media do mes " + meses[i] + ":");
    temperatura[i] = int.Parse(Console.ReadLine()!);

}

float MaiorTemperatura = temperatura[0];
float MenorTemperatura = temperatura[0];

for (int i = 0; i < temperatura.Length; i++)
{
    if (temperatura[i] > MaiorTemperatura)
    {
        MaiorTemperatura = temperatura[i];
    }

    if (temperatura[i] < MenorTemperatura)
    {
        MenorTemperatura = temperatura[i];

    }
    
}

Console.WriteLine($"A maior temperatura do ano foi: {MaiorTemperatura} °C");
Console.WriteLine($"A menor temperatura do ano foi: {MenorTemperatura} °C");