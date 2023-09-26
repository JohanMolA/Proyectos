// Primer Examen Parcial

Academia miAcademia = new Academia {Nombre = "Club Santos Laguna", Propietario = "Johan MolA", Domicilio = "Calle LALA #1"};

// Agregar jugadores a la academia

miAcademia.AgregarJugador (new Jugador { Nombre = "Hachita Ludueña", AñoNac = 2000, Sexo = 'M', Becado = true });
miAcademia.AgregarJugador(new Jugador { Nombre = "Osvaldo Sanchez", AñoNac = 2001, Sexo = 'M', Becado = true });
miAcademia.AgregarJugador(new Jugador { Nombre = "Vicente Vuoso", AñoNac = 2002, Sexo = 'M', Becado = false });

// Agregar categorias a los jugadores

miAcademia.Categorias[0].AgregarJugador (new Categoria { Nombre = "Fuerzas Basicas", Rango = "2000/2001/2002", Costo = 2000});
miAcademia.Categorias[1].AgregarJugador(new Categoria { Nombre = "Fuerzas Basicas", Rango = "2000/2001/2002", Costo = 2000 });
miAcademia.Jugadores[2].AgregarCategoria(new Categoria { Nombre = "Fuerzas Basicas", Rango = "2000/2001/2002", Costo = 2000 });

//Reporte

Console.Clear();
Console.WriteLine("Reporte\n");
Console.WriteLine(miAcademia.ToString());
Console.WriteLine($"\nTotal de Jugadores: {miAcademia.Jugadores.Count()}");
Console.WriteLine($"\nTotal de Categorias: {miAcademia.Categorias.Count()}");

Console.WriteLine("\n>> Datos generales de los jugadores <<\n");
foreach (Jugador jugador in miAcademia.Categorias)
{
    Console.WriteLine(categoria.ToString());
}

// Categorias de los jugadores

Console.WriteLine("\n>> Categorias de los jugadores <<\n");
foreach (Jugador jugador in miAcademia.Jugadores)
{
    Console.WriteLine($"\n>{jugador.Nombre} - {jugador.AñoNac} - ({jugador.Categorias.Count})<\n");
    foreach (Categoria categoria in jugador.Categorias)
    {
        Console.WriteLine(categoria.ToString());
    }
    Console.WriteLine($"- Subtotal: {jugador.Subtotal(),36:c2}\n");
}
Console.WriteLine($"\n\n- Total: {miAcademia.Total(),40:c2}");