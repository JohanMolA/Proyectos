public class Banco
{
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    public List <Cliente> Cliente {get; set;}
    public Banco () => Cliente = new List <Cliente> ();
    public Banco (string nombre, string direccion) : this () => (Nombre, Direccion) = (nombre, direccion);
    public void AgregarCliente (Cliente cliente) => Cliente.Add (cliente);
    public override string ToString () => $"Nombre: {Nombre}, Direccion: {Direccion}";
}