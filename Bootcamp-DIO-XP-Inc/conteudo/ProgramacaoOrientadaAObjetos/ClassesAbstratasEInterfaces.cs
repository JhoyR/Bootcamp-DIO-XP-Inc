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
    *   
    *   
    *   
    *   
    *   
    *   
    *   
    */
    
    public static void UsingAbstractMethod()
    {
        Corrente c = new Corrente();
        c.Creditar(560);
        c.ExibirSaldo();
    }
}
