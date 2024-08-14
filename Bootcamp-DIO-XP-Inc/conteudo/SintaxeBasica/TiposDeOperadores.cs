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

            bool choveu = false;
            bool estaTarde = false;

            if (choveu && estaTarde)
            {
                Console.WriteLine("Deixa pra próxima");
            }
            else
            {
                Console.WriteLine("É hoje!");
            }
        }

        public static void ArithmeticOperators()
        {
            /*
            *   Soma: +
            *   Subtração: -
            *   Multiplicação: *
            *   Divisão: / (representa a parte inteira, ou double)
            *   Módulo: % (resto da divisão)
            *   Incremento: ++ (aumenta o valor em 1. x = x + 1)
            *   Decremento: -- (diminui o valor em 1. x = x - 1)
            */
            Somar(8, 4);
            Subtrair(8, 4);
            Multiplicar(8, 4);
            Dividir(8, 4);
            Incremento();
            Decremento();
            Potencia(2, 3);
            RaizQuadrada(16);

            static void Somar(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }

            static void Subtrair(int x, int y)
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            }

            static void Multiplicar(int x, int y)
            {
                Console.WriteLine($"{x} x {y} = {x * y}");
            }

            static void Dividir(int x, int y)
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }

            static void Incremento()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Incremento, i = {i}");
                }
            }

            static void Decremento()
            {
                for (int i = 5; i > 3; i--)
                {
                    Console.WriteLine($"Decremento, i = {i}");
                }
            }

            void Potencia(int x, int y)
            {
                double pot = Math.Pow(x, y);
                Console.WriteLine($"{x} ^ {y} = {pot}");
            }

            void RaizQuadrada(double x){
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
            }
        }

        public static void TrigonometricsOperators()
        {
            Seno(30);
            Cosseno(30);
            Tangente(30);

            static void Seno(double angulo){
                double radiano = angulo * Math.PI / 180; // É igual a: angulo * (Math.PI / 180)
                double seno = Math.Sin(radiano); //Recebe um ângulo em radianos
                Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}"); //Arredonda o valor da variável para o 
            }

            static void Cosseno(double angulo){
                double radiano = angulo * Math.PI / 180;
                double cosseno = Math.Cos(radiano);
                Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno, 4)}");
            }

            static void Tangente(double angulo){
                double radiano = angulo * Math.PI / 180;
                double tangente = Math.Tan(radiano);
                Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
            }
        }
    }
}