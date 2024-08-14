namespace Bootcamp.Common.Models
{

    public class Pessoa
    {
        public string Nome { get; set; } 
        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos.");
        }
    }
}