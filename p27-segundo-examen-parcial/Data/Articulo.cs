using System.ComponentModel.DataAnnotations;
public class Articulo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(3), MaxLength(35)]
    public string Descripcion { get; set; }

    [Range(typeof(DateTime), "01/01/2023",  "31/12/2024", ErrorMessage = "Fecha no valida")]
    public DateTime FechaAlta { get; set; }

    [Range(1, 100)]
    public int Cantidad { get; set; }

    [Range(1, 2500)]
    public double Precio { get; set; }

    public string UdeMedida { get; set; }
}