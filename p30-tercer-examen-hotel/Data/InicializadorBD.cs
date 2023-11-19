public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Clientes.Any()) {
            return;
        }

        var clientes = new List<Cliente> {
            new Cliente { Nombre = "Ramonello", Apellido = "Thiem", Genero='H', FechaCumple = DateTime.Parse("09-05-1970"), Correo="M1c@yahoo.com", Telefono="4926548791", Edad=53},
            new Cliente { Nombre = "Carlos", Apellido = "Castañeda", Genero='H', FechaCumple = DateTime.Parse("06-07-1980"), Correo="carlitos123@gmail.com", Telefono="4923124657", Edad=43},
            new Cliente { Nombre = "Azucena", Apellido = "Ramírez", Genero='M', FechaCumple = DateTime.Parse("01-01-1950"), Correo="azu007@gmail.com", Telefono="4926518493", Edad=73},
            new Cliente { Nombre = "Jessica", Apellido = "Carrillo", Genero='M', FechaCumple = DateTime.Parse("04-09-2001"), Correo="jess@hotmail.com", Telefono="4921479365", Edad=22},
            new Cliente { Nombre = "Pedro", Apellido = "Pereyra", Genero='H', FechaCumple = DateTime.Parse("19-04-2002"), Correo="Pcerouno@gmail.com.mx", Telefono="4927539510", Edad=22},
        }; 
        contexto.Clientes.AddRange(clientes); 
        contexto.SaveChanges();

        var habitaciones = new List<Habitacion> {
            new Habitacion {HabitacionId=1, NoHab=101, Tipo="Individual", Piso=1, Costo=1250.00},
            new Habitacion {HabitacionId=2, NoHab=102, Tipo="Individual", Piso=2, Costo=1250.00},
            new Habitacion {HabitacionId=3, NoHab=201, Tipo="Doble", Piso=2, Costo=2700.00},
            new Habitacion {HabitacionId=4, NoHab=202, Tipo="Doble", Piso=4, Costo=2700.00},
            new Habitacion {HabitacionId=5, NoHab=301, Tipo="Triple", Piso=1, Costo=3500.00},
            new Habitacion {HabitacionId=6, NoHab=301, Tipo="Triple", Piso=2, Costo=3500.00},
            
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        var reservaciones = new List<Reservacion> {
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Pereyra").Id, HabitacionId = habitaciones.Single(c => c.NoHab==101 && c.Piso==1 ).HabitacionId, InicioReserva = DateTime.Parse("12-11-2023"), FinReserva = DateTime.Parse("12-12-2023")},
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Castañeda").Id, HabitacionId = habitaciones.Single(c => c.NoHab==302 && c.Piso==3).HabitacionId, InicioReserva = DateTime.Parse("26-12-2023"), FinReserva = DateTime.Parse("05-01-2024")}
        };
            contexto.Reservaciones.AddRange(reservaciones);
            contexto.SaveChanges();
        }
}