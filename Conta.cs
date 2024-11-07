using System.Runtime.CompilerServices;

public class Saldo
{
    private double _saldo = 0;

    public void SetSaldo(double saldo)
    {
       
        if (saldo >= 0)
        {
            _saldo = saldo;
            Console.WriteLine("Seu saldo é: "+ saldo);
        }
        else
        {
            Console.WriteLine("Saldo incorreto!");
        }
    }
}