using System.ComponentModel.DataAnnotations;

public class Cliente {
    public int Id {get; set;}

    [Required, StringLength(30)]
    public string Nombre {get; set;}

    [Required, StringLength(30)]
    public string Apellido {get; set;}

    public char Genero { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString= "{0:dd-mm-yyyy}", ApplyFormatInEditMode=true)]
    public DateTime FechaCumple {get; set;}

    [EmailAddress]
    public string Correo { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe tener 10 dígitos.")]
    public string Telefono {get; set;}

    public string NombreCompleto {
        get { return Nombre + " " + Apellido; }
    }

    public int Edad {get; set;}

    public ICollection<Reservacion> Reservaciones {get; set;}
}