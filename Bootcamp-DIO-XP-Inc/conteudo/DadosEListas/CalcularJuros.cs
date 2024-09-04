namespace Bootcamp_DIO_XP_Inc.conteudo.DadosEListas;

public class CalcularJuros
{
    public static void Calculadora()
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P

        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i

        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
        // Calcula o montante final utilizando a função CalcularJurosCompostos
        double montanteComposto = CalcularJurosCompostos(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteComposto);
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        // TODO: Calcule e retorne o montante final com juros simples
        double montante = P + (P * i * n);
        return montante;
    }

     public static double CalcularJurosCompostos(double P, double i, int n)
    {
       // TODO: Calcule e retorne o montante final com juros compostos
       double montanteComposto =  P * Math.Pow(1 + i, n);
       return montanteComposto;
    }
}
