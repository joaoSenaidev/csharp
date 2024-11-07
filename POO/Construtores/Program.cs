using System.ComponentModel;
using Construtores.Classes;

List<Jogo> estoqueJogos = new List<Jogo>();

Veiculo Carro1 = new Veiculo("BMW", "320i", 2014, "Preto lunar");
Veiculo Carro2 = new Veiculo("Ford", "Fiesta", 2017, "Vermelho");

Jogo game = new Jogo("Detroit", 2018, "Ação eletronica", 120.900f);
Jogo game2 = new Jogo("Call of Duty", 2003, "Tiro, Ação", 290.900f );
Jogo game3 = new Jogo("Clash Royale ", 2016, "Estrategia em Tempo real", 00.000f );
Jogo game4 = new Jogo("Little nightmares", 2017, "Suspense", 290.900f );


Aluno aluno1 = new Aluno("Joao", 2020, 17);
Aluno aluno2 = new Aluno("Pedro", 2019, 19);



// Carro1.Marca = "BMW";
// Carro1.Modelo = "320i";
// Carro1.Ano = 2014;
// Carro1.Cor = "Preto lunar";

// Carro2.Marca = "Ford";
// Carro2.Modelo = "Fiesta";
// Carro2.Ano = 2017;
// Carro2.Cor = "Vermelho";

// exibir os dados colocados

Console.Clear();

Carro1.ExibirDados();
Carro2.ExibirDados();

Console.WriteLine();

game.ExibirDadosJG();
game2.ExibirDadosJG();

Console.WriteLine();

aluno1.ExibirDadosAL();
aluno2.ExibirDadosAL();

estoqueJogos.Add(game);
estoqueJogos.Add(game2);
estoqueJogos.Add(game3);
estoqueJogos.Add(game4);

    foreach (var jogo in estoqueJogos)
    {
        jogo.ExibirDadosJG();
        Console.WriteLine();
    
    }

do
{
    Console.WriteLine
    (@$" *********Menu de Opções*********
        |                                 |
        |    1) Cadastrar Jogo            |
        |    2) Listar Jogos              |
        |    0) Sair                      |
        |                                 |
        ***********************************");

    int Escolha = int. Parse(Console.ReadLine()!);
    


} while (Escolha == 0);
