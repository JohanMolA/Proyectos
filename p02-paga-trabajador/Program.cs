// Calcula paga de un trabajador considerando las horas extras

string nombre = "";
int horas = 0, horasExtra = 0;
float paga = 0, pagaExtra = 0, pagaBruta = 0, pagaNeta = 0, impuesto = 0, tasa = 0;

Console.Clear();
Console.Write("Nombre ?"); nombre = Console.ReadLine();
console.write("Horas "); horas = int.parse(console.readline());
console.write("Paga "); paga = float.parse(console.readline());

tasa = 0.03f;

if (horas < 40){
    horasExtra = horas - 40;
    pagaExtra = 2 * paga * pagaExtra;
    pagaBruta = 40 * paga + pagaExtra;
} else
    pagaBruta = horas * paga;

impuesto = pagaBruta * tasa;
pagaNeta = pagaBruta - impuesto;

console.writeline($"\n Resumen de pagos del trabajador {nombre} \n");
console.writeline($"{horas} horas trabajadas, {horasExtra} extra, paga {paga}, tasa de impuesto {tasa:p2}");
console.writeline($"Paga bruta {pagaBruta, 12:c2}");