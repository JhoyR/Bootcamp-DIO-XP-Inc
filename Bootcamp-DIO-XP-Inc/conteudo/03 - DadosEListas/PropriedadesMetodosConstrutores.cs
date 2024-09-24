using System.Configuration.Assemblies;
using Bootcamp.Common.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.PropriedadesMetodosConstrutores;

public class PropriedadesMetodosConstrutores
{
    /**
    *   Propriedades
    *       Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.
    */

    public static void UsingProperties()
    {
        Pessoa pessoa = new Pessoa( "Jhoy");
        // pessoa.Nome = "Jhoy";
        pessoa.Sobrenome = "Rodrigues";
        pessoa.Idade = 24;

        pessoa.Apresentar();
    }

    /* Modificadores de acesso
    * 
    *   public: qualquer um pode acessar
    *   private: só é acessível dentro da própria classe
    *
    */

    public static void UsingMethods()
    {
        /*  Um método é um bloco de código que contém uma série de instruções   */
        Pessoa pessoa1 = new Pessoa("Joao", "Silva");
        // pessoa1.Nome = "Joao";
        // pessoa1.Sobrenome = "Silva";

        /*
        * Construtores
        *   Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexívels e fáceis de ler.
        *
        *    Construtor - Deve ter o mesmo nome da classe e não possui retorno
        *    Podemos ter quantos construtores quisermos
        */
        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Paulo";
        pessoa2.Sobrenome = "Teixeira";

        Pessoa pessoa3 = new Pessoa(nome: "Marcos", sobrenome: "Oliveira"); //Tornando a passagem de parâmetros mais legível


        Curso cursoDeIngles = new Curso();
        cursoDeIngles.Nome = "Ingles";
        cursoDeIngles.Alunos = new List<Pessoa>();

        cursoDeIngles.AdicionarAluno(pessoa1);
        cursoDeIngles.AdicionarAluno(pessoa2);
        cursoDeIngles.AdicionarAluno(pessoa3);
        cursoDeIngles.ListarAlunos();
    }
}
