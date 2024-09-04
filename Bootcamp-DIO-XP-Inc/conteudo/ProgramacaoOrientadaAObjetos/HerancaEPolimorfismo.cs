using Bootcamp.Common.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.ProgramacaoOrientadaAObjetos;

public class HerancaEPolimorfismo
{
    /*
    *   Herança
    *       A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
    *       Serve para agrupar objetos que são do mesmo tipo, porém, com características diferentes.
    *   
    *       Não se pode herdar mais de uma classe por vez.
    *       Uma superclasse pode ter varias subclasses e uma subclasse pode ter uma subclasse dela, levando as propriedades hierarquicamente.
    *       
    *   Polimorfismo
    *       O polimorfismo vem do grego e significa "muitas formas".
    *       Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.
    *       "Sobrescrever para se comportar de maneira diferente"
    *       
    */


    public static void ShowHeritage()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Bento";
        aluno.Sobrenome = "Mangaravite";
        aluno.Idade = 16;
        aluno.Email = "bento.mangaravite@email.com";
        aluno.Apresentar();

        Professor professor = new Professor();
        professor.Nome = "Sebastião";
        professor.Sobrenome = "Soares";
        professor.Idade = 30;
        aluno.Email = "tiao.soares@email.com";
        professor.Salario = 2000;
        professor.Apresentar();
    }
}
