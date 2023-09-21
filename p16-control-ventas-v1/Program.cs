// Control de Ventas de una tienda

Tienda miTienda = new Tienda {Nombre = "Ferreteria Alameda", Domicilio = "AV. Alameda", Propietario = "Johan MolA"};

//Agregar clientes a la tienda

miTienda.AgregarCliente (new Cliente {Nombre = "Jelipe Cabras", RFC = "JELI650536", Domicilio = "La Pura 69", Correo = "jeli0807@gmail.com"});
miTienda.AgregarCliente(new Cliente { Nombre = "Kike Niet", RFC = "KINI873015", Domicilio = "Islas Cana 777", Correo = "kikeniet05@gmail.com"});
miTienda.AgregarCliente(new Cliente { Nombre = "Andy Lo", RFC = "ANLO654890", Domicilio = "Mejico 05", Correo = "anlo19@gmail.com"});
miTienda.AgregarCliente(new Cliente { Nombre = "Sochil Tl", RFC = "SOTL050316", Domicilio = "Dannone 99", Correo = "sochi7@gmail.com"});

// Agregar ventas a los clientes

miTienda.Clientes[0].AgregarVenta (new Venta {Articulo = "Martillo", Cantidad = 10, Precio = 60.5});
miTienda.Clientes[0].AgregarVenta (new Venta {Articulo = "Pala", Cantidad = 2, Precio = 170.55});
miTienda.Clientes[1].AgregarVenta(new Venta { Articulo = "Clavo", Cantidad = 2.5, Precio = 60.34 });
miTienda.Clientes[1].AgregarVenta(new Venta { Articulo = "Cinta de aislar", Cantidad = 5, Precio = 7.34 });
miTienda.Clientes[1].AgregarVenta(new Venta { Articulo = "Pinzas", Cantidad = 1, Precio = 650.33 });
miTienda.Clientes[2].AgregarVenta(new Venta { Articulo = "Thiner", Cantidad = 5, Precio = 65.00 });

//Reporte

Console.Clear();
Console.WriteLine("Reporte de ventas\n");
Console.WriteLine(miTienda.ToString());
Console.WriteLine($"\nTotal de Clientes: {miTienda.Clientes.Count()}");
Console.WriteLine($"\nTotal de Ventas: {miTienda.Clientes.Count()}");

Console.WriteLine("\n>> Datos generales de los clientes <<\n");
foreach (Cliente cliente in miTienda.Clientes)
{
    Console.WriteLine(cliente.ToString());
}

// Ventas de los clientes

Console.WriteLine("\n>> Ventas de los clientes <<\n");
foreach (Cliente cliente in miTienda.Clientes)
{
    Console.WriteLine($"\n>{cliente.Nombre} - {cliente.RFC} - ({cliente.Ventas.Count})<\n");
    foreach (Venta venta in cliente.Ventas)
    {
        Console.WriteLine(venta.ToString());
    }
    Console.WriteLine($"- Subtotal: {cliente.Subtotal(), 36:c2}\n");
}

Console.WriteLine($"\n\n- Total: {miTienda.Total(), 40:c2}");