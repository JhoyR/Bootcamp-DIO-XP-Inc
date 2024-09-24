using Bootcamp.Common.Interfaces;
using Bootcamp.Common.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.ProgramacaoOrientadaAObjetos;

public class ClassesAbstratasEInterfaces
{
    /*
    *   Classe abstrata (abstract)
    *       Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.
    *       Ela deve ser obrigatóriamente herdada, caso queira trabalhar com esta classe.
    *       Você pode implementar métodos ou deixá-los a cargo de quem herdar.
    *   
    *   Classe selada (sealed)
    *       Uma classe selada tem como objetivo de impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada.
    *       Também existem métodos e propriedades seladas.
    *       Pode herdar, mas não pode ser herdada (Classes e métodos)
    *   
    *   Classe objetct
    *       A classe System Object é a mãe de todas as classes na hierarquia do .NET
    *       Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.
    *   
    *   Interfaces
    *       Uma interface é um contrato que pode ser implementado por uma classe.
    *       É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.
    *       Assim como uma classe abstrata, uma interface não pode ser instanciada.
    *       Exige a toda classe que implementar a interface, deverá implementar também, os métodos da interface.
    *       
    *       Métodos que não tem corpo, são obrigatórios para implementação, e os que tem corpo, são opcionais.
    *   
    *   
    */

    public static void UsingAbstractMethod()
    {
        Corrente c = new Corrente();
        c.Creditar(560);
        c.ExibirSaldo();

        Pessoa p1 = new Pessoa("Jhoy"); //Exige o nome, devido construtor por herança
        Aluno a1 = new Aluno("Joaquim");
        a1.Apresentar();

        // Não podemos instanciar uma interface, mas podemos  criar um objeto interface recebendo uma classe que a implementa.
        ICalculadora calc = new Calculadora();
        Console.WriteLine(calc.Somar(3, 7));
    }
}
