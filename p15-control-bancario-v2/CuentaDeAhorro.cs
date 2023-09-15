public class CuentaDeAhorro : CuentaBancaria
{
    public double Interes {get; set;}
    public CuentaDeAhorro (double Saldo, double interes) : base (Saldo) => Interes = interes;
    public void CalcularInteres () => Saldo += (Saldo * Interes);
}