using System.Security.Cryptography.X509Certificates;

namespace Bootcamp.Common.Models;

public class Professor : Pessoa //Herda de pessoa
{
    public decimal Salario { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario:C}.");
    }
}
