using Bootcamp.Common.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.ProgramacaoOrientadaAObjetos;

public class IntroducaoAbstracaoEncapsulamento
{
    /*
    *   Introducao POO
    *       A POO é um paradigma de programação, ou seja, corresponde a uma técnica de programação para um fim específico.
    *       Dentro desta técnica, existem quatro pilares:
    *       - Abstração;
    *       - Encapsulamento;
    *       - Herança;
    *       - Polimorfismo.
    *   
    *       O principal conceito da POO são classes e objetos
    *       - Classe: Representação de um objeto da vida real. (Pessoa, carro, etc)
    *       
    *       As classes possuem métodos(ou funções) e atributos(características);
    *       - Objeto: É uma classe concretizada, "o que faz a classe se tornar real".
    *   
    *   Paradigmas de Programação
    *       Um paradigma nada mais é do que um modelo de técnicas, estruturas e formas de solucionar um problema.
    *       Paradigma de programação é diferente de linguagem de programação.
    *       Uma linguagem de programação implementa um ou mais paradigmas. 
    *       
    *           - Programação orientada a objetos
    *           - Programação estruturada
    *           - Programação imperativa
    *           - Programação procedural
    *           - Programacao orientada a eventos
    *           - Programacao lógica
    *   
    *   Abstração
    *       Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.
    *       Devemos representar somente o que for importante para nossos sistema.
    *   
    *   Encapsulamento
    *       O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades.
    *       Serve para ocultar seu comportamento e expor somente o necessário.
    *        - Na documentação, as propriedades ou métodos antecedidas por '+' são públicas e, as antecedidas por '-' são privadas.
    *       
    *   
    */

    public static void UsingEncapsulation()
    {
        ContaCorrente conta = new ContaCorrente(123, 1000);
        // conta.saldo = 1200; saldo não é acessível
        conta.ExibirSaldo();
        conta.Sacar(500);
        conta.ExibirSaldo();
    }

}
