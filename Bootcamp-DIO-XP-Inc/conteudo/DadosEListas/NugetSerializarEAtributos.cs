using System.Text.Json.Nodes;
using Bootcamp.Common.Models;
using Newtonsoft.Json;

namespace Bootcamp_DIO_XP_Inc.conteudo.DadosEListas;

public class NugetSerializarEAtributos
{
    /*
    *   Gerenciador de pacotes
    *       Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código.
    *       Nuget é um gerenciador de pacotes, que permite desenvolvedores compartilharem códigos e bibliotecas.
    *       Para verificar os pacotes disponíveis do Nuget, podemos acessar 'nuget.org'
    *   
    *   Para instalar um pacote pelo VS Code, acesse o site oficial Nuget, encontre o pacote desejado, na aba .NET CLI
    *   será fornecido um código para ser executado no terminal.
    *       Normalmente será: 'dotnet add package nome_do_pacote'
    *   Para verificar instalação, verificar no arquivo .csproj, se existe uma referência de pacote do pacote instalado.
    *   Pelo Visual Studio, há uma aba exclusiva para pacotes nuget, podendo ser verificado tanto no .csproj, quanto na aba dependências.
    *   
    *   
    *   Serialização de Dados
    *       - O que é serialização e deserialização?
    *       O processo de serializar consiste em transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão.
    *       Transforma um objeto em outro tipo de estrutura, como uma tradução.
    *   
    *       - JSON
    *       Javascript Notation Object é um formato de texto que segue a sintaxe do Javascript, muito usado para transmitir dados entre aplicações. 
    *           ex.:{
    *                   "id": 1,
    *                   "produto": "p1",
    *                   "preco": 10.50 
    *               }
    *   
    */

    public static void PraticSerialization()
    {
        DateTime dataVenda = DateTime.Now;
        List<Venda> listaVendas = new List<Venda>();

        Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataVenda);
        Venda v2 = new Venda(1, "Licença de software", 110.00M, dataVenda);

        listaVendas.Add(v1);
        listaVendas.Add(v2);

        // Pode ser usado para objetos individuais ou listas/coleções
        string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //Formatting.Idented: Adiciona quebra de linhas no corpo do json retornado
        //File.WriteAllText("Files/Vendas.json", serializado); //Cria um arquivo serializado com as informações
        // Console.WriteLine(serializado);

        string conteudoArquivo = File.ReadAllText("Files/Vendas.json");

        List<Venda> listVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

        foreach (Venda venda in listVenda)
        {
            Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda:dd/MM/yyyy HH:mm}");
        }

    }
}
