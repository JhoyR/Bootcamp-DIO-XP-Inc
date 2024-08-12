using Bootcamp_DIO_XP_Inc.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.IntroducaoAoAmbiente.SintaxeBasica;

public class SintaxeETiposDeDados
{
        /*
        *   Sintaxe e Convenções
        *       arquivo program.cs: Representa uma classe do C#.
        *       arquivo .csproj: Representa um arquivo de projeto do C#, e contém informações sobre o projeto em questão.
        *       pasta obj: Referente à arquivos de debug ou compilação.
        *       pasta bin: Pasta de binários, armazena os binários da aplicação após compilada.
        *   Obs: As pastas acima são geradas ao executar build do projeto, não necessitando da presença das mesmas ao iniciar um projeto.
        *   
        *   Classe
        *       | Nome: string
        *       | Idade: int
        *       Está relacionada aos conceitos de abstração na programação orientada a objetos.
        *       Uma abstação é a transformação de um objeto do mundo real em um objeto na programação.
        *       Em uma abstração, é composta por dados que fazem sentido ser representados na situação. Mais que isso gerará poluição de software.
        *       Uma classe é um conceito representado do mundo real.
        *       
        *   Método
        *       | apresentar()
        *       É uma ação que será executada pela sua classe. É sempre acompanhado de '()', que pode ser preenchido com os parâmetros, quando houverem.
        *   
        *   Por convenção, as classes sempre se iniciam com letra maiúscula e, quando houver mais de uma palavra, utiliza-se os padrões Case:
                camelCase, PascalCase.
        *   Nas classes, existem as chaves "{}" que determinam onde se iniciam e se encerram.
        *   
        *   O namespace é o endereço lógico da classe.
        *   
        *   A palavra reservada 'new' é utilizada para instanciação/construção de uma classe.
        *   
        *   Classes e métodos sempre se iniciam com letras maiúsculas, seguindo PascalCase. Já as variáveis sempre se iniciam com letras minúsculas, seguindo o camelCase.
        *   
        *   RECOMENDAÇÕES:
        *       - Não é recomendável utilizar abreviações, mesmo quando o nome da variável for grande. O código precisa ser de fácil compreensão e interpretação. Sempre por extenso.
        *       - É recomendável também que, o nome do arquivo físico seja o mesmo da classe.
        *       - É Recomendável também, não utilizar caracteres especiais nas variáveis. Exceto o underline (_).
        *   
        *******************************************************************************************************************************************************************************
        *                       TIPOS DE DADOS  
        *   string: Uma cadeia de caracteres
        *   char: Um caracter unicode
        *   object: Tipo de objeto
        *   bool: Um tipo booleano, representado por Verdadeiro (true) ou Falso (false).
        *   byte: Int não atribuído de 8-bits.
        *   decimal: Valores decimais com 28-29 dígitos significativos.
        *   double: Tipo de ponto flutuante de precisão dupla de 64 bits.
        *   int: Tipo inteiro com sinal de 32 bits.
        *   float: Tipo de ponto flutuante com precisão simples de 32 bits.
        *   long: Tipo inteiro com sinal de 64 bits.
        *   uint: Tipo inteiro sem sinal de 32 bits. (Sem números negativos, dobra valores positivos)
        *   short: Tipo inteiro com sinal de 16 bits.
        *   ulong: Tipo inteiro sem sinal de 64 bits. (Sem números negativos, dobra valores positivos)
        *   
        *   
        *   Não é permitido declarar uma mesma variável duas vezes no mesmo escopo. O escopo é definido entre as chaves "{}".
        *   
        *   O DateTime é uma maneira de representar datas no C#. Ela representa data e hora, com milissegundos.
        */
        public static void Presentation()
        {
                Console.WriteLine("Hello, World!");

                Pessoa pessoa = new Pessoa
                {
                        Nome = "Jhoy",
                        Idade = 24
                };

                string apresentacao = "Olá, seja bem vindo";

                Console.WriteLine(apresentacao);
                pessoa.Apresentar();
        }

        public static void Quantity()
        {
                int quantidade = 2;
                Console.WriteLine("Valor da variável quantidade: " + quantidade);

                quantidade = 10; //sobrescrito por novo valor
                Console.WriteLine("Valor da variável quantidade: " + quantidade);

                double altura = 1.83;

                decimal preco = 1.80M; //O M representa um decimal, quando passamos um valor literal (diretamente). 

                bool condicao = true;

                Console.WriteLine("Valor da variável altura: " + altura);
                Console.WriteLine("Valor da variável preço: " + preco);
                Console.WriteLine("Valor da variável condição: " + condicao);

                /********************************************************************************/

                DateTime dataAtual = DateTime.Now.AddDays(4);
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        }
}