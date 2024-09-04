using System.Text.Json.Serialization;

namespace Bootcamp.Common.Models;

public class Venda
{
    public Venda()
    {

    }
    public Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }
    public int Id { get; set; }
    [JsonPropertyName("Nome_Produto")] //Muda o comportamento da informação a ser buscada
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
}