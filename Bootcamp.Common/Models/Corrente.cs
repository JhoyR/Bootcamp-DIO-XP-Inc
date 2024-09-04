namespace Bootcamp.Common.Models;

public class Corrente : Conta
{
    //Todo método abstrato deve ser implementado ao ser herdado
    public override void Creditar(decimal valor)
    {
       saldo += valor;
    }
}
