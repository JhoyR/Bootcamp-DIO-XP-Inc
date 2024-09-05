namespace Bootcamp.Common.Interfaces;

public interface ICalculadora
{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2) //Método opcional
    {
        return num1 / num2;
    }
}
