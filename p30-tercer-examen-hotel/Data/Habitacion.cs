using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Habitacion {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int HabitacionId{get; set;}
    [Range(1,30)]
    public int NoHab {get; set;}
    [Required, StringLength(10)]
    public string Tipo {get; set;}
    [Range(1,4)]
    public int Piso {get; set;}
    [Required, Range(1,5000)]
    public double Costo {get; set;}

    public string HabitacionCompleta {
        get { return "Tipo:" + Tipo + "-NoHab:" + NoHab + "-Piso:" + Piso; }
    }

    public string HabitacionCompleta2 {
        get { return "Tipo:" + Tipo + "-NoHab:" + NoHab + "-Piso:" + Piso + "-Costo:" + Costo; }
    }

    public string HabitacionCompleta3 {
        get { return Tipo + " " + NoHab + " " + Piso + " " + Costo.ToString("C"); }
    }

    public ICollection<Reservacion> Reservaciones {get; set;}

}