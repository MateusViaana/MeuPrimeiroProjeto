//Saldo s = new Saldo();
//Console.WriteLine("Digite o seu saldo: ");
//double saldo = Convert.ToDouble(Console.ReadLine());
//s.SetSaldo(saldo);

//try
//{
//    Console.WriteLine("Digite um valor: ");
//    int  valor = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(valor/0);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("ERRO AO TENTAR DIVIDIR POR ZERO!");
//}
//catch (Exception ex )
//{
//    Console.WriteLine("Valor informado invalida!" + ex.Message);

//}

try
{
    Saldo s = new Saldo();
    Console.WriteLine("Digite o seu saldo: ");
    double saldo = Convert.ToDouble(Console.ReadLine());
    s.SetSaldo(saldo); 

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
