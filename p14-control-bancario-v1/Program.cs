// Control Bancario

// Probar clase Cuenta Bancaria

CuentaBancaria cuenta = new CuentaBancaria(100);
cuenta.Deposita(200);
Console.WriteLine($"Saldo : {cuenta.Saldo}");
cuenta.Retira(150);

if (cuenta.Retira(1500)) Console.WriteLine("Retiro Exitoso");
else Console.WriteLine("No se puede retirar, saldo insuficiente");

Console.WriteLine($"Saldo : {cuenta.Saldo}");
// Probar clase cliente
Cliente cliente1 = new Cliente ("Juan Carlos", "jcarlos@gmail.com", cuenta);
cliente1.Cuenta = cuenta;
cliente1.Cuenta.Deposita(1500);
Console.WriteLine($"\n Datos del cliente : {cliente1.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente1.Cuenta.Saldo}");

Cliente cliente2 = new Cliente ("Paola Diaz", "paolad@msn.com", new CuentaBancaria(450));
Console.WriteLine($"\n Datos del cliente : {cliente2.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente2.Cuenta.Saldo}");
// Probar la clase banco
Banco miBanco = new Banco ("Banco del Bienestar", "En cas de la jodida");
miBanco.AgregarCliente(cliente1);
miBanco.AgregarCliente(cliente2);
miBanco.AgregarCliente(new Cliente("Xochitl", "xochitl@hotmail.com", new CuentaBancaria(200)));

Console.WriteLine(miBanco.ToString());
Console.WriteLine($"El banco tiene {miBanco.Clientes.Count} clientes");

foreach (Cliente cl in miBanco.Clientes)
{
    Console.WriteLine($"Cliente : {cl.ToString()}");
    Console.WriteLine($"Saldo   : {cl.Cuenta.Saldo}");
}