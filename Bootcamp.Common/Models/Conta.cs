namespace Bootcamp.Common.Models;

public abstract class Conta
{
    //Protegido contra alterações externas, com exceção das suas classes filhas.
    protected decimal saldo; 

    // Só serve para ser herdado, não tem uma implementação, é apenas a assinatura do método, quem herdar, deve obrigatóriamente ser implementado.
    public abstract void Creditar(decimal valor);

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é: {saldo}");
    }
}
