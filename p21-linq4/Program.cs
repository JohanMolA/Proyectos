List <Estudiante> estudiantes = new List <Estudiante> ();

estudiantes.Add (new Estudiante ("1234", "Juan Perez", "Principal 123", "Jerez", 'H', 22, true, new List <float> {97, 81, 92, 60}));
estudiantes.Add(new Estudiante("5678", "Kiki Andy", "Secundaria 123", "Fresnillo", 'H', 24, true, new List<float>{98, 87, 90, 70}));
estudiantes.Add(new Estudiante("9101", "Rodri Mata", "Tercera 3", "Zacatecas", 'H', 28, true, new List<float>{75, 80, 84, 68}));
estudiantes.Add(new Estudiante("1213", "Masha Bear", "Russia 19", "Malpaso", 'M', 20, true, new List<float>{90, 78, 87, 68}));
estudiantes.Add(new Estudiante("1415", "David Monre", "Zairo 666", "Guadalupe", 'H', 58, false, new List<float>{60, 64, 75, 50}));
estudiantes.Add(new Estudiante("1617", "Simona Hall", "Washin 84", "Jerez", 'M', 29, true, new List<float>{92, 86, 88, 70}));
estudiantes.Add(new Estudiante("1819", "Garbiñe Mugu", "España 02", "Zacatecas", 'M', 22, true, new List<float>{90, 60, 87, 84}));

Console.WriteLine("\n Todos los estudiantes en el grupo");
estudiantes.ForEach (e => Console.WriteLine(e));

string mun = "Fresnillo";
var estmun = (from e in estudiantes where e.Municipio == mun select e).ToList();
Console.WriteLine($"\n Estudiantes que son de {mun} - {estmun.Count()}");
estmun.ForEach(estmun => Console.WriteLine(e));

float prom = 6.5f;
var estprom = (from e in estudiantes where e.Califs.Average() => prom orderby e.Nombre select e).ToList();
Console.WriteLine($"\n Estudiantes con promedio >=  {prom} - {estprom.Count()}");
estmun.ForEach(estmun => Console.WriteLine(e));

var estprom1 = (from e in estudiantes select $"Nombre: {e.Nombre, -18} - Prom: {e.Califs.Average(), 5:n2} Becado: {e.Becado}").ToList();
Console.WriteLine("\n Lista de alumnos y promedio");
estprom1.ForEach(e => Console.WriteLine(e));

Console.WriteLine("\n\n Subtotales");

var promedades = (from e in estudiantes select e.Edad).Average();
Console.WriteLine($"Promedio de edades = {promedades:n2}");

var promcalifs = (from e in estudiantes select e.Califs.Average()).Average();
Console.WriteLine($"Promedio de promedios = {promcalifs:n2}");

var totm = (from e in estudiantes where e.Sexo == 'M' select e).Count();
Console.WriteLine($"Total de mujeres = {totm}");
var toth = (from e in estudiantes where e.Sexo == 'H' select e ).Count();
Console.WriteLine($"Total de hombres = {toth}");

var totbe = (from e in estudiantes where e.Becado select e).Count();
Console.WriteLine($"Total de Becados = {totbe}");
var totnbe = (from e in estudiantes where e.Becado select e).Count();
Console.WriteLine($"Total de No Becados = {totnbe}");

var totmbe = (from e in estudiantes where e.Becado && e.Sexo == 'M'select e).Count();
Console.WriteLine($"Total de Mujeres Becadas = {totmbe}");

var gpoest = from e in estudiantes group e by e.Municipio;
Console.WriteLine($"Estudiantes agrupados por municipio");
foreach (var gpo in gpoest)
{
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach (var est in gpo)
    {
        Console.WriteLine(est);
    }
}