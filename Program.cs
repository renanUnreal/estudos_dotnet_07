// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("====================================================");
Console.WriteLine("====== Bem vindo ao meu primeiro sistema ===========");
Console.WriteLine("====================================================");

double v1 = 0.0;
double v2 = 0.0;
double resultado = 0.0;
Console.WriteLine("Digite um numero separando as casas por virgula : ");
var informacao = Console.ReadLine();
Console.WriteLine("Digite outro numero separando as casas por virgula : ");
var informacao2 = Console.ReadLine();

v2 = Convert.ToDouble(informacao2);

v1 = Convert.ToDouble(informacao);

resultado = v1 + v2;

Console.WriteLine($"Valor digitado pelo usuário : {resultado}");

Console.WriteLine("=============== Fim do sistema ======================");
*/

// taboada

int numero = 0;
int multiplicador = 0;

Console.WriteLine("====================================================");
Console.WriteLine("====== Bem vindo ao meu primeiro sistema ===========");
Console.WriteLine("====================================================");

Console.WriteLine("Digite o numero da taboada que deseja exibir");
var input = Console.ReadLine();

numero = Convert.ToInt16(input);

Console.WriteLine("Digite o multiplicador da taboada que deseja exibir");
input = Console.ReadLine();

multiplicador = Convert.ToInt16(input);


if (numero > 0 || multiplicador > 1)
{
    Console.WriteLine("====================================================");
    Console.WriteLine($"============ Taboada do {numero}  =================");
    for (int i = 0; i <= multiplicador; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
    }
    Console.WriteLine("=============== Fim do sistema ======================");
}
