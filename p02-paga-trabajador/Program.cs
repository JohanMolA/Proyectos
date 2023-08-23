// Calcula paga de un trabajador considerando las horas extras

string nombre = "";
int horas = 0, horasExtra = 0;
float paga = 0, pagaExtra = 0, pagaBruta = 0, pagaNeta = 0, impuesto = 0, tasa = 0;

Console.Clear();
Console.Write("Nombre ?"); nombre = Console.ReadLine();
Console.Write("Horas "); horas = int.Parse(Console.ReadLine());
Console.Write("Paga "); paga = float.Parse(Console.ReadLine());

tasa = 0.03f;

if (horas < 40){
    horasExtra = horas - 40;
    pagaExtra = 2 * paga * pagaExtra;
    pagaBruta = 40 * paga + pagaExtra;
} else
    pagaBruta = horas * paga;

impuesto = pagaBruta * tasa;
pagaNeta = pagaBruta - impuesto;

Console.WriteLine($"\n Resumen de pagos del trabajador {nombre} \n");
Console.WriteLine($"{horas} horas trabajadas, {horasExtra} extra, paga {paga}, tasa de impuesto {tasa:p2}");
Console.WriteLine($"Paga bruta {pagaBruta, 12:c2}");
