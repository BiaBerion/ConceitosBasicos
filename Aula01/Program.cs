// See https://aka.ms/new-console-template for more information
using Aula01._1bim;
using System.Runtime.InteropServices;

int num1 = 20;
int num2 = 22;
SomaDoisNumeros somador = new SomaDoisNumeros();
int resultado = somador.Somar(num1, num2);
Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");


int metro = 20;
MetrosMilimetros transformador = new MetrosMilimetros();
int milimetro = transformador.Tranformar(metro);
Console.WriteLine($"O valor {metro} em milimetros é igual a {milimetro}");

bool escolher = true
while ()





/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
