// Calcula las estadisticas basicas de un arreglo de calificaciones

const int MAX = 100;
double[] calif = null;

int n=0;
double may=0, men=0, prom=0, var=0, desv=0;

Console.Clear();
Console.WriteLine("Cuantos elementos ?");
n = int.Parse(Console.ReadLine());

if(n>MAX) 
{
    Console.WriteLine("El maximo es {0}", MAX);
    return 1;
}

calif = new double[n];
for(int i=0; i<calif.Length; i++)
{
    Console.Write($"calif[{i}]= ");
    calif[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine($"Los elementos del arreglo son : {est.Imprime(calif)}");

est.Imprime(calif);
may = est.Mayor(calif);
men = est.Menor(calif);
prom = est.Promedio(calif);
var = est.Varianza(calif, prom);
desv = Math.Sqrt(var);

Console.WriteLine("\n Resumen de estadisticas \n");

Console.WriteLine($"Cantidad de calif {calif.Length}");
Console.WriteLine($"El mayor es {may:f2}");
Console.WriteLine($"El menor es {men:f2}");
Console.WriteLine($"El promedio es {prom:f2}");
Console.WriteLine($"La varianza es {var:f2}");
Console.WriteLine($"La desviacion es {desv:f2}");

return 0;