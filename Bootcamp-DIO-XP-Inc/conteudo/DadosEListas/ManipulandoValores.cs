using System.Globalization;

namespace Bootcamp_DIO_XP_Inc.conteudo.DadosEListas;

public class ManipulandoValores
{
    /*
    *  
    */

    public static void Concatenation()
    {
        int numero1 = 10;
        string numero2 = "20";

        string resultado = numero1 + numero2;
        Console.WriteLine(resultado);

    }

    public static void MonetaryValue()
    {
        decimal valorMonetario = 82.40M;
        Console.WriteLine($"{valorMonetario:C}"); // os dois pontos definem que queremos formatar a variável.
                                                  // O 'C' define o valor monetário atual, com base na cultura do sistema.

        // Alterando a localização do sistema
        // Importar Globalization: using System.Globalization;

        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Definir a cultura do sistema

        //Para passar um valor de cultura em um caso específico
        Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        // Formatação personalizada: Casas decimais
        Console.WriteLine(valorMonetario.ToString("C2")); //Ou N2, para 2 casas decimais

        //Representando porcentagem
        double porcentagem = .3421;
        Console.WriteLine(porcentagem.ToString("P")); //Padrão definido para Porcentagens

        int numero = 123456;
        Console.WriteLine(numero.ToString("##-##-##")); // Retorna 12-34-56


        // Formatando o tipo DateTime
        DateTime dataAtual = DateTime.Now; //Pega data e hora atual do sistema
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Formato especificado no ToString, disponivel na documentação

        // Representações de data
        Console.WriteLine(dataAtual.ToShortDateString());
        Console.WriteLine(dataAtual.ToLongDateString());
        Console.WriteLine(dataAtual.ToShortTimeString());
        Console.WriteLine(dataAtual.ToShortTimeString());

        // DateTime com TryParse, conversão segura
        string dataString = "2022-04-14 18:00";
        //Validando retorno do TryParseExact
        bool success = DateTime.TryParseExact(dataString, "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime data);
        Console.WriteLine(data);

        if (success)
        {
            Console.WriteLine($"Conversão com sucesso! Data: {data}");
        }
        else
        {
            Console.WriteLine($"{dataString} Não é uma data válida");
        }
    }
}
