// Control Bancario v2

Banco miBanco = new Banco ("Banco del Norte SA de CV", "Privada las Cumbres 123");
miBanco.AgregarCliente (new Cliente ("Carlos Fuentes", "cfuentes@gmail.com", new List <CuentaBancaria> 
{
    new CuentaDeAhorro (1500, 0.10),
    new CuentaDeAhorro (2500, 0.20),
    new CuentaDeAhorro (6500, 500)
}));
miBanco.AgregarCliente(new Cliente("Juan de la Fuente", "juanfuente@gmail.com", new List<CuentaBancaria>
{
    new CuentaDeAhorro (2500, 500)
}));

miBanco.AgregarCliente (new Cliente ("Rene Mayorga", "renemayo@msn.com", new List <CuentaBancaria> ()));
miBanco.Cliente[2].AgregarCuenta(new CuentaDeCheques(16500, 1500));
miBanco.Cliente[2].AgregarCuenta(new CuentaDeCheques(116500, 0.4));
miBanco.AgregarCliente(new Cliente("Juan Perez", "jperez.uaz.edu.mx", new List<CuentaBancaria>()));
miBanco.Cliente[3].AgregarCuenta(new CuentaDeCheques(12500, 0.30));

miBanco.Cliente[2].Cuentas[1].Retira(110000);
miBanco.Cliente[1].Cuentas[0].Deposita(110000);

Console.Clear();
Console.WriteLine($"Reporte de clientes del banco {miBanco.ToString()}");
Console.WriteLine($"El banco tiene {miBanco.Cliente.Count} clientes \n");
foreach (Cliente cte in miBanco.Cliente)
{
    Console.WriteLine($"\n Cliente: {cte.ToString()}, tiene {cte.Cuentas.Count} cuentas");
    foreach (CuentaBancaria cta in cte.Cuentas)
    {
        Console.WriteLine((cta is CuentaDeCheques) ?"Cuenta de Cheques" : "Cuentas de Ahorro");
        if (cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres();
        Console.WriteLine($", con un saldo de {cta.Saldo:n2}");
    }
}