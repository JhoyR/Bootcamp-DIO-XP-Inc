namespace Bootcamp_DIO_XP_Inc.conteudo.SintaxeBasica;

public class ArraysEListas
{
    /*  Array
    *   
    *       O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.
    *   1. int[] array = new int[4];
    *   2. int[] array = new int[] {42, 75, 74, 71}
    *   3. string[] nomes = {"Jan", "Fev"};
    *   
    *   COMO PODEMOS ACESSAR OS VALORES DE UM ARRAY?
    *   - Índice: É a posição de um determinado valor de um array, sempre começando com zero.
    *       Valores: | 42 | 75 | 74 | 61 |
    *       Posição: |  0 |  1 |  2 |  3 |
    *   
    *   1. int elemento = array[0]
    *   2. array[0] = 42 (substituir valor da posição zero)
    *   
    */

    public static void ThroughArray()
    {

        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;
        // arrayInteiros[3] = 1; /*RETORNA ERRO POR SER ÍNDICE MAIOR QUE A CAPACIDADE DO ARRAY*/

        //CASO PRECISE DO VALOR DO CONTADOR,UTILIZE O FOR
        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
        }

        Console.WriteLine("\nPercorrendo com Foreach...");

        int count = 0;
        //CASO NÃO PRECISE DO VALOR DO CONTADOR,UTILIZE O FOREACH
        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine($"Posição N° {count} - {valor}");
            count++;
        }
    }

    public static void IncreaseSizeArray()
    {
        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;
        arrayInteiros[3] = 1;

        Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //Dobrando a capacidade do array

    }

    public static void CopyToNewArray()
    {
        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

        /*Enquanto o resize atribui o novo tamanho ao mesmo array, o Copy adiciona o existente a um novo*/
        Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length/*passar tudo*/);

        foreach (var pos in arrayInteirosDobrado)
        {
            Console.WriteLine($"{pos}");
        }
    }

    public static void UsingLists()
    {
        /*Uma lista é um array melhorado, capaz de representar coleções de objetos de mesmo tipo, sem a necessidade de definir a capacidade máxima*/
        /*Uma lista pode ser definida como uma extensão de um array*/

        List<string> listaString = ["SP", "BA", "MG"]; /*Pode ser inicializada ou vazia*/

        listaString.Add("RJ");
        listaString.Add("ES");


        /*PODEMOS PERCORRER UMA LISTA COM FOR OU FOREACH*/
        for(int contador = 0; contador < listaString.Count; contador++){
            Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
        }

        /*PARA REMOVER UM ITEM DE UMA LISTA*/
        listaString.Remove("MG");


        Console.WriteLine("\nPercorrendo com Foreach...");
        int contadorForeach = 0;
        foreach(string item in listaString){
            Console.WriteLine($"Posição N° {contadorForeach} - {item}");
            contadorForeach++;
        }



    }

}
