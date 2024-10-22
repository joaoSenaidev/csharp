// variaveis e tipos de dados
Console.WriteLine($"Olá, digite seu nome: ");
string nome = Console.ReadLine() ;


Console.WriteLine($"Agora {nome} digite seu sobrenome ");
string sobrenome = Console.ReadLine();


// calcular na base da DtNascimento
Console.WriteLine($"{nome} {sobrenome} que ano voce nasceu? ");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;




Console.WriteLine($"Digite seu cpf ");
UInt128 cpf = UInt128.Parse (Console.ReadLine()!);

Console.WriteLine($"Digite seu telefone");
UInt128 telefone = UInt128.Parse (Console.ReadLine()!);

Console.WriteLine($"Digite seu email");
string  email = Console.ReadLine();

Console.WriteLine($"Digite seu endereço");
string endereço = Console.ReadLine()!;

Console.WriteLine($"Digite seu estado civil");
string  EstadoCivil = Console.ReadLine();



// cwl
Console.WriteLine($@"Cadastro completo:  
{nome}  {sobrenome}
    {email}
    {cpf}
    {telefone}
    {endereço}
    {EstadoCivil}
    {idade}
");







// estrutura condicionais
// laços de repetição
// array