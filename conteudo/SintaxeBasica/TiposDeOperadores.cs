using System.Diagnostics;

namespace Bootcamp_DIO_XP_Inc.conteudo.SintaxeBasica
{
    public static class TiposDeOperadores
    {
        public static void Operators()
        {
            /*
            *   OPERADOR DE ATRIBUIÇÃO
            *       O operador de atribuição '=' atribui o valor do operando do lado direito a uma variável, uma '=' ou um elemento indexador fornecido pelo operando do lado esquerdo. 
            *   O resultado de uma expressão de atribuição é o valor atribuído a um operando do lado esquerdo. O tipo do operando do lado direito deve ser o mesmo ou implicitamente 
            *   conversível para o operando do lado esquerdo. 
            *
            */
            int a = 10;
            int b = 20;

            int c = a + b;
            c += 5;  /*É o mesmo que: c = c + 5*/
            Console.WriteLine(c);

            /*CONVERTENDO TIPOS DE VARIÁVEIS*/
            /*Conversão: Cast - Casting
            *
            *       Diferença entre Convert e Parse
            *   Quando tentamos converter um valor nulo(null) para inteiro:
            *       - Ao utilizar o Convert, é retornado zero(0).
            *       - Ao utilizar o int.Parse, é gerada uma exceção, e encerrando a aplicação.
            *
            *   É recomendado utilizar o Convert, por não ocasionar uma exceção, e fazer o tratamento correto dessa condição.
            */
            int d = Convert.ToInt32(null);
            // d = int.Parse("5c"); //retorna erro de valor
            Console.WriteLine(d);

            /*CONVERSÃO PARA STRING*/
            int inteiro = 5;
            string e = inteiro.ToString();
            Console.WriteLine(e);

            /*CASTING IMPLÍCITO*/
            int f = 5;
            double g = f; //Converte implícitamente int em double (O oposto não é permitido diretamente)
            long h = f; //Converte implícitamente int em long (O oposto não é permitido diretamente)
            Console.WriteLine(g);

            int i = Convert.ToInt32(h); //EM alguns casos é possível fazer este tipo de conversão.

            /*Ordem dos operadores
            *   Segue a mesma ordem da matemática
            */
            int j = 4 / 2 + 2; // = 4
            int j2 = 4 / (2 + 2); // = 1
            Console.WriteLine(j);
            Console.WriteLine(j2);

            /*CONVERTENDO DE MANEIRA SEGURA*/
            string k = "15";
            //int l = Convert.ToInt32(k); //Pode retornar exceção, se o valor for inválido.
            int m = 0;
            int.TryParse(k, out m); //O TryParse espera um erro, ele tenta converter e, caso funcione, o valor de saída vai para a variável passada no 'out'.

            Console.WriteLine(m);
            Console.WriteLine("Conversão realizada com sucesso!");






        }

        public static void ConditionalOperators()
        {
            /*      Operador condicional
            *   
            *   O operador condicional possibilita mudar o fluxo de execução de seu código, indicando um caminho que ele deve percorrer.
            *   if, else.
            */

            int quantidadeEmEstoque = 10;
            int quantidadeCompra = 4;
            bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"É possível realizar a venda? {(possivelVenda ? "Sim" : "Não")}"); //Operador ternário

            /*IF ANINHADO*/
            if (quantidadeCompra == 0)
            {
                Console.WriteLine("Venda inválida");
            }
            else if (possivelVenda)
            {
                quantidadeEmEstoque -= quantidadeCompra;
                Console.WriteLine("Venda realizada!");
            }
            else
            {
                Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
            }
            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");

            /*SWITCH CASE*/
            Console.Write("Digite uma letra:");
            string letra = Console.ReadLine();
            if (!string.IsNullOrEmpty(letra) && (letra.GetType() == typeof(string)))
            {
                switch (letra)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine("Vogal");
                        break;
                    default:
                        Console.WriteLine("Consoante");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        public static void LogicOperators()
        {
            /*  OPERADORES LÓGICOS 
            *   Negação: ! ou ~
            *   E: &&
            *   Ou: ||
            *   Igual: ==
            *   Diferente: !=
            *   Maior: >
            *   Maior ou igual: >=
            *   Menor: <
            *   Menor ou igual: <=
            */
            bool p = true;
            bool q = false;

            if (p && q)
            {
                Console.WriteLine("True");
            }
            if (p || q)
            {
                Console.WriteLine("True");
            }
            if (p && !q)
            {
                Console.WriteLine("True");
            }

            bool choveu= false;
            bool estaTarde = false;

            if(choveu && estaTarde){
                Console.WriteLine("Deixa pra próxima");
            }
            else{
                Console.WriteLine("É hoje!");
            }
        }
    }
}