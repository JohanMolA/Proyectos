// Calcula la distancia entre 2 puntos dados

double ax=0, bx=0, ay=0, by=0, distancia=0;

Console.Clear();

Console.WriteLine("Punto ax ?");
ax = Double.Parse(Console.ReadLine());
Console.WriteLine("Punto bx ?");
bx = Double.Parse(Console.ReadLine());
Console.WriteLine("Punto ay ?");
ay = Double.Parse(Console.ReadLine());
Console.WriteLine("Punto by ?");
by = Double.Parse(Console.ReadLine());

distancia = Math.Sqrt((Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)));

Console.WriteLine($"La distancia es: {distancia}");
