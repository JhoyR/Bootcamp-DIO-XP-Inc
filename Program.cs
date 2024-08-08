using Bootcamp_DIO_XP_Inc.Models;


/********************************************************************************/

Console.WriteLine("Hello, World!");

Pessoa pessoa = new Pessoa
{
    Nome = "Jhoy",
    Idade = 24
};

pessoa.Apresentar();

/********************************************************************************/

string apresentacao = "Olá, seja bem vindo";

int quantidade = 2;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

quantidade = 10; //sobrescrito por novo valor
Console.WriteLine("Valor da variável quantidade: " + quantidade);

double altura = 1.83;

decimal preco = 1.80M; //O M representa um decimal, quando passamos um valor literal (diretamente). 

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);

/********************************************************************************/

DateTime dataAtual = DateTime.Now.AddDays(4);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
