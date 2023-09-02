// Programa para la venta de articulos con IVA

double precio=0, subtotal=0, iva=0;
char respuesta;
int cantidad, eleccion, ventas=0;

do
{
    Console.Clear();
    Console.WriteLine("Productos a elegir\n");
    Console.WriteLine("1 Refresco $25");
    Console.WriteLine("2 Papas $15");
    Console.WriteLine("3 Galletas $20");
    Console.WriteLine("4 Pan $8");
    Console.WriteLine("5 Chicles $5");
    Console.WriteLine("\n Seleccione un articulo: ");
    eleccion = int.Parse(Console.ReadLine());

    switch (eleccion) 
    {
        case 1:
            precio = 25;
            Console.WriteLine("Cuantos ?");
            cantidad = int.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            ventas = cantidad;
            break;
        case 2:
            precio = 15;
            Console.WriteLine("Cuantos ?");
            cantidad = int.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            ventas = cantidad;
            break;
        case 3:
            precio = 20;
            Console.WriteLine("Cuantos ?");
            cantidad = int.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            break;
        case 4:
            precio = 8;
            Console.WriteLine("Cuantos ?");
            cantidad = int.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            break;
        case 5:
            precio = 5;
            Console.WriteLine("Cuantos ?");
            cantidad = int.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            break;
        default:
            eleccion = 0;
            Console.WriteLine("Seleccione una opcion");
            break;
    }

    Console.WriteLine($"Deseas realizar otra compra (S/N) ?");
    respuesta = char.ToUpper(Console.ReadLine()[0]);

} while (respuesta != 'N');

if (subtotal <= 120)
{
    iva = subtotal * 0.16;
    double total = subtotal + iva;
    Console.WriteLine($"El total es: ${total}");
}
else
{
    Console.WriteLine($"Total: ${subtotal}");
}
Console.WriteLine($"Numero de ventas: {ventas}");