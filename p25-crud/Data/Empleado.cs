using System.ComponentModel.DataAnnotations;

public class Empleado
{
    [Key] //llave primaria
    public int Id {get; set;}
    [Required, MinLength(3), MaxLength(35)] //Valor minimo y maximo para el nombre
    public string Nombre {get; set;}
    [RegularExpression (@"[ña-z]{3,4}[0-9]{6}[0-9a-z]{3}$")] //para que cumpla la expresion regular
    public string Rfc {get; set;}
    [Range(18, 35)] //rango de edades validas
    public int Edad {get; set;}
    public string Genero {get; set;}
    [EmailAddress] //exclusivo para el correo
    public string Correo {get; set;}
    public double Salario {get; set;}
}