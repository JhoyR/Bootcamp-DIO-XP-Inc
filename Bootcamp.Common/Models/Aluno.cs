namespace Bootcamp.Common.Models;

public class Aluno : Pessoa //Herda de pessoa
{
    public Aluno(string nome) : base(nome) //Construtor por herança
    {

    }
    
    public Aluno()
    {

    }
    
    public double Nota { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}.");
    }
}
