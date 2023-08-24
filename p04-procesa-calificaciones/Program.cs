// Procesa n calificaciones introducidas por el usuario

int n=0, ne=0;
float cal=0, suma=0, prom=0, promgen=0;
string  status="";
char resp;

do{
    Console.Clear();
    prom=suma=n=0;
    Console.WriteLine("Procesa calificaciones del semestre ago-dic 2023, 666 para terminar \n");

    do
    {
        Console.Write("Calificacion ? "); cal=float.Parse(Console.ReadLine());
        if (cal!=666)
        {
            suma+=cal;
            n++;
        }
    } while (cal!=666);
    prom=suma/n;
    status=prom>=7 ? "Aprobado" : "Reprobado";

    Console.WriteLine($"Capturaste {n} calificaiones");
    Console.WriteLine($"La suma de las calificaciones es {suma:f2}");
    Console.WriteLine($"El promedio es {suma/n:f2}");
    Console.WriteLine($"Tu status es de {status}");
    ne++;
    promgen+=prom;
    Console.WriteLine($"Deseas capturar las calificaciones de otro estudiante (S/N) ?");
    resp=char.ToUpper(Console.ReadLine()[0]);
} while(resp!='N');
promgen/=ne;
Console.WriteLine($"Se procesaron las calificaciones de {ne} estudiantes ");
Console.WriteLine($"Promedio general de la clase {promgen}");
