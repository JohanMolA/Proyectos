public class InicializadorBD
{
    public static void Inicializar (ContextoDatos contexto)
    {
        if (contexto.Articulos.Any ())
        {
            return;
        }
        var articulos = new Articulo [] 
        {
             new Articulo {Id = 1, Descripcion = "Suavitel", FechaAlta = DateTime.Parse ("14/06/2023"), Cantidad = 3, Precio = 35.50, UdeMedida = "Litro"},
             new Articulo {Id = 2, Descripcion = "Jabon liquido", FechaAlta = DateTime.Parse ("10/03/2023"), Cantidad = 5, Precio = 27.50, UdeMedida = "Litro"},
             new Articulo {Id = 3, Descripcion = "Shampoo", FechaAlta = DateTime.Parse ("02/04/2023"), Cantidad = 2, Precio = 50.00, UdeMedida = "Litro"},
             new Articulo {Id = 4, Descripcion = "Jabon en polvo", FechaAlta = DateTime.Parse ("10/03/2023"), Cantidad = 2, Precio = 82.50, UdeMedida = "Caja"}
        };
        contexto.Articulos.AddRange (articulos);
        contexto.SaveChanges ();
    }
}