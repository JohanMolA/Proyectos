public class InicializadorBD
{
    public static void Inicializar(ContextoDatos contexto)
    {
        if (contexto.Jugadores.Any())
        {
            return;
        }
    var jugadores = new Jugador[] {
    new Jugador {Id = 1234, Nombre = "Kiki Martinez", FechaNac = DateTime.Parse ("14/06/2001"), NoPlayera = 1, Posicion = "Portero", Apariciones = 20, Goles = 0},
    new Jugador {Id = 1235, Nombre = "Juanito Bananas", FechaNac = DateTime.Parse("04/05/2002"), NoPlayera = 2, Posicion = "Defensa", Apariciones = 18, Goles = 1},
    new Jugador { Id = 1236, Nombre = "Pancho Pizzas", FechaNac = DateTime.Parse("10/07/2001"), NoPlayera = 3, Posicion = "Defensa", Apariciones = 19, Goles = 0},
    new Jugador { Id = 1237, Nombre = "Juan Perez", FechaNac = DateTime.Parse("18/01/2003"), NoPlayera = 4, Posicion = "Lateral", Apariciones = 16, Goles = 1}
    };
        contexto.Jugadores.AddRange(jugadores);
        contexto.SaveChanges();
    }
}