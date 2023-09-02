// Calificaciones con mensajes

int n=0; //numero de calificaciones
float prom=0, suma=0, cal=0;

Console.Clear();

Console.WriteLine("Para terminar de escribir calificaciones, teclea el numero 666 \n");
do
{
    Console.Write("Calificacion ? "); cal = float.Parse(Console.ReadLine());
    if (cal != 666)
    {
        suma += cal;
        n++;
    }
} while (cal != 666);
prom = suma / n;

do
{
    if (prom <= 5.9) 
        Console.WriteLine($"{prom} D Andas Mal"); 
        else if (prom > 6 || prom < 7.5)
            Console.WriteLine($"{prom} C Mucho Mejor");
        else if (prom > 7.6 || prom < 8.5)
            Console.WriteLine($"{prom} B Muy Bien");
        else if (prom > 8.6 || prom <= 10)
            Console.WriteLine($"{prom} A Excelente");
} while (prom < 0);
