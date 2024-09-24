namespace Bootcamp_DIO_XP_Inc.conteudo.DadosEListas;

public class ExcecoesEColecoes
{
    #region Exceções
    /*
    *   Exceptions
    *       Os recursos de manipulação de exceção da linguagem C# ajudam você a lidar com
    *       quaisquer situações excepcionais ou inesperadas que ocorram quando um programa
    *       for executado.
    *       Uma exceção corta o fluxo de execução de um programa, encerrando-o e passando
    *       informações para rastrear onde ocorreu a exceção.
    *
    *       Try...Catch
    *           Um bloco try, tenta executar um trecho do código, estando preparado para
    *           tratar uma possível exceção. Pode-se utilizar vários catch para um try
    *
    *       Finally
    *           Um bloco finally executa a finalização do código, independente de ocorrer 
    *           uma exceção ou não.
    *           Um exemplo para finally, é quando executamos alguma operação no banco de 
    *           dados, onde independente de dar erro ou não, precisamos fechar/encerrar
    *           a conexão.
    *
    *       Throw
    *           É quando jogamos uma exceção para ser pega por outro trecho do programa.
    *           De forma que leve até a próxima etapa monitorada por um try...catch ou
    *           na raiz do programa.
    *           
    *       StackTrace
    *           É uma mensagem com as informações de onde o programa tentou chegar.
    *           O caminho até a exceção.
    *
    *       As exceções devem ser usadas com cautela, sendo recomendadas apenas quando
    *       realmente não tivermos controle do dado. Para coisas mais simples não compensa.
    */

    public static void ReadingFile()
    {
        try
        {
            // Ao lidar com mais de um projeto, passar pasta do projeto onde o arquivo está.
            string[] linhas = File.ReadAllLines("Bootcamp-DIO-XP-Inc/Files/arquivoLeitura.txt");

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
        }

        Console.WriteLine($"Chegou até aqui!");
    }
    #endregion

    #region Filas
    /*
    *   Uma fila é como uma fila da vida real (banco, supermercado, etc), a primeira pessoa
    *   da fila, vai ser a primeira a ser atendida, e a última, vai para o final da fila.
    *
    *   Uma coleção do estilo fila, respeita a essas regras. FIFO - 'First In, First Out'
    *
    */
    public static void UsingQueues()
    {
        Queue<int> fila = new Queue<int>(); //Cria uma fila de inteiros

        fila.Enqueue(2); // Adiciona um objeto ao final da fila
        fila.Enqueue(3);
        fila.Enqueue(4);
        fila.Enqueue(5);

        foreach (int item in fila)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); //Remove o primeiro elemento da fila, somente o primeiro

        fila.Enqueue(8);
        foreach (int item in fila)
        {
            Console.WriteLine(item);
        }
    }
    #endregion

    #region  Pilhas
    /*
    *   Na pilha, respeita-se o tipo LIFO - 'Last In, First Out'
    *   Ou seja, o último que entra, é o primeiro que sai.
    */

    public static void UsingStack()
    {
        Stack<int> pilha = new Stack<int>();

        pilha.Push(2); //Insere um objeto no topo da pilha
        pilha.Push(4);
        pilha.Push(6);
        pilha.Push(8);

        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}"); //Remove e retorna o objeto no topo da fila
        pilha.Push(20);

        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }
    }
    #endregion

    #region  Dicionário
    /*
    *   Dictionary
    *       Um dictionary é uma coleção de chave-valor para armazenar valores
    *       únicos sem uma ordem específica. As chaves não podem ser duplicadas,
    *       mas os valores, sim.
    */

    public static void UsingDictionary()
    {
        Dictionary<string, string> estados = new Dictionary<string, string>(); // O primeiro elemento é a chave e o segundo, o valor

        estados.Add("ES", "Espírito Santo");
        estados.Add("SP", "São Paulo");
        estados.Add("MG", "Minas Gerais");
        estados.Add("BA", "Bahia");

        foreach (var item in estados)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }
        Console.WriteLine("----------");

        estados.Remove("BA"); // Para remover um item do dicionário, passa-se a chave do item desejado

        // As chaves não podem ser alteradas, elas são as referências para alterar os valores desejados
        estados["SP"] = "São Paulo - valor alterado";

        foreach (var item in estados)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        string chave = "BA";
        Console.WriteLine($"Verificando o elemento: {chave}");

        if (estados.ContainsKey(chave))
        {
            Console.WriteLine($"Valor existente: {chave}");
        }
        else
        {
            Console.WriteLine($"O valor não existe. É seguro adicionar a chave: {chave}");
        }

        // Obter um valor existente
        Console.WriteLine($"Acessando valor: {estados["MG"]}");
    }
    #endregion
}
