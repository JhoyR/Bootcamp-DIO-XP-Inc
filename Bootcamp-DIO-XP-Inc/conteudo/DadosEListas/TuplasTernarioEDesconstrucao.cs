using Bootcamp.Common.Models;

namespace Bootcamp_DIO_XP_Inc.conteudo.DadosEListas;
public class TuplasTernarioEDesconstrucao
{
    /*
    *   Tuplas
    *       Tuplas fornece sintaxe concisa para agrupar vários elementos
    *       de dados em uma estrutura de dados leve.
    *       Uma tupla não é uma coleção, mas pode ter, dentro de si, uma
    *       coleção.
    *   
    */

    public static void UsingTuples()
    {
        // Exemplo de declaração de tupla
        (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Jhoy", "Rodrigues", 1.83M); // Os nomes das variáveis são opcionais

        Console.WriteLine($"Id: {tupla.Id} | Nome: {tupla.Nome} | Sobrenome: {tupla.Sobrenome} | Altura: {tupla.Altura}");

        ValueTuple<int, string, string, decimal> valueTuple = tupla; //Outro exemplo de criação de tupla
        var outroExemploTupla = Tuple.Create(1, "Jhoy", "Rodrigues", 1.83M);


        // Para chamar métodos não estáticos, devemos instanciá-los antes
        TuplasTernarioEDesconstrucao arquivo = new TuplasTernarioEDesconstrucao();
        var (sucesso, linhasArquivo, quantidade) = arquivo.ReadingFilesTuple("Bootcamp-DIO-XP-Inc/Files/arquivoLeitura.txt"); //Desconstrução do retorno na tupla

        //Descarte de elementos na tupla - utilizando o underline '_'
        var (sucesso1, linhasArquivo1, _) = arquivo.ReadingFilesTuple("Bootcamp-DIO-XP-Inc/Files/arquivoLeitura.txt");


        if (sucesso)
        {
            Console.WriteLine($"Quantidade de linhas do arquivo: {quantidade}");
            foreach (string linha in linhasArquivo)
            {
                Console.WriteLine(linha);
            }
        }
        else
        {
            Console.WriteLine("Não foi possível ler o arquivo.");
        }

        Pessoa p1 = new Pessoa("Jhoy", "Rodrigues"); //Construindo - Passando as variáveis na declaração
        (string nome, string sobrenome) = p1; //Desconstruindo - Retornando variáveis separadas do objeto (Neste caso, vindas de p1)

        Console.WriteLine($"{nome} {sobrenome}");
    }
    
    public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) ReadingFilesTuple(string caminho)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count()); //Retorno da tupla esperada no método
        }
        catch (Exception)
        {
            return (false, new string[0], 0);
        }
    }

    public static void UsingTernary()
    {
        int numero = 20;

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
        }
        
        // Operador ternario realizando a mesma tarefa anterior
        Console.WriteLine($"O número {numero} é " + (numero % 2 == 0 ? "par" : "ímpar"));
    }
}
