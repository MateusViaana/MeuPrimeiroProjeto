using System.Runtime.CompilerServices;

public class Saldo
{
    private double _saldo = 0;

    public void SetSaldo(double saldo)
    {

        try
        {
            if (saldo >= 0)
            {
                _saldo = saldo;
                Console.WriteLine("Seu saldo é: " + saldo);
            }
            else
            {
                throw new Exception("Saldo não pode ser negativo!");

            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message); ;
        }
        
    }
}


