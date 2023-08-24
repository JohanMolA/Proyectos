// Imprime una tabla de conversion de peso a otras monedas

int ini, fin, c;
float tcd=17.70f, tcl=21.21f, tce=18.19f, tca=0.048f;

Console.Clear();
Console.WriteLine("Imprime tabla de conversion de monedas \n");

do
{
    Console.Write("Inicio : "); ini=int.Parse(Console.ReadLine());
    Console.Write("Fin    : "); fin=int.Parse(Console.ReadLine());
} while (fin<ini); // Valida que ini sea menor que fin

c=ini;
Console.WriteLine("Peso \t Dolar \t Libra \t Euro \t Peso Arg");
Console.WriteLine(new string('-',35));
while (c<=fin)
{
    Console.WriteLine($"{c:f2} \t {c/tcd:f2} \t {c/tcl:f2} \t {c/tce:f2} \t {c/tca:c2}");
    c++;
}
Console.WriteLine(new string('-', 35));
