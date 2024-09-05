namespace Bootcamp.Common.Models;

public class Diretor : Professor
{
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um diretor e ganho {Salario:C}.");
    }
}
