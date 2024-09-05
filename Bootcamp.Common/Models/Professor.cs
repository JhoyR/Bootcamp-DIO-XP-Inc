using System.Security.Cryptography.X509Certificates;

namespace Bootcamp.Common.Models;

public class Professor : Pessoa //Herda de pessoa
{
    // base (nome) - quer dizer que está passando 'nome' para a classe pai, como se estivesse usando o construtor dela
    public Professor(string nome) : base(nome) //Construtor por herança
    {

    }

    public Professor()
    {

    }

    public decimal Salario { get; set; }

    public sealed override void Apresentar() //Não permite que o método seja herdado
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario:C}.");
    }
}
