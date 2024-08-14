
namespace Bootcamp_DIO_XP_Inc.conteudo.SintaxeBasica;

public class EstruturasDeRepeticao
{
    /*
    *   Enquanto uma condição for verdadeira, executa uma determinada tarefa.
    *   É uma execução repetidas vezes de uma determinada tarefa, até chegar a um objetivo.
    *
    */
    public static void RepeatLoop()
    {
        int numero = 5;
        // Iniciando em 0, equanto for menor ou igual a 10, incrementar 1 ao contador (enquanto a condição for verdadeira).
        //Ao chegar em 11, retornará falso, pois é maior que 10, portanto, sai do loop.
        for (int contador = 0; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} x 1 = {numero * contador}");
        }

        int contador2 = 0;
        int numero2 = 5;
        //Enquanto determinada condição for verdadeira, repete o loop.
        //É necessário definir uma condição para que o programa saia desse loop. 
        while (contador2 <= 10)
        {
            Console.WriteLine($"{contador2}° Execução: {numero2} X {contador2} = {numero2 * contador2} ");
            contador2++;
            //Interromper fluxo de execução
            if (contador2 == 5)
            {
                break;
            }
        }

        //Do While, é uma extensão do While, porém, com verificação ao final do bloco
        int soma = 0, digito = 0; //É permitido declarar mais de uma variável de mesmo tipo em uma mesma linha.

        do
        {
            Console.WriteLine("Digite um número:");
            digito = Convert.ToInt32(Console.ReadLine());

            soma += digito;
        } while (digito != 0);

        Console.WriteLine($"Total da soma dos números digitados é: {soma}");

        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;

                case "2":
                    Console.WriteLine("Busca de cliente");
                    break;

                case "3":
                    Console.WriteLine("Apagar cliente");
                    break;

                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    // Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

}
