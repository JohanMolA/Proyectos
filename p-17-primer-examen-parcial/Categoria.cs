public class Categoria
{
    public string Nombre {get; set;}
    public string Rango {get; set;}
    public double Costo {get; set;}
    public List <Categoria> Categorias {get; set;}

    public Categoria() => Categorias = new List <Jugador>();
    public Categoria (string nombre, string rango, double costo) : this() => (Nombre, Rango, Costo) = (nombre, rango, costo);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public double Subtotal()
    {
        double total = 0;
        foreach (Jugador jugador in Jugadores)
            total = total + jugador.Total;
        return total;
    }
    public override string ToString() => $"Nombre: {Nombre, -20}Rango: {Rango, -15}Costo: {Costo:c2}";
}