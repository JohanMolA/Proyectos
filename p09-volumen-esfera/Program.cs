// Calcula el volumen de una esfera

double radio, volumen, pi=3.1415926535;

Console.Clear();

Console.WriteLine("Valor del radio ?"); radio = Double.Parse(Console.ReadLine());

volumen = 4 / 3 * pi * (radio * radio * radio);

Console.WriteLine($"El volumen de la esfera es: {volumen}");