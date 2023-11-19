using System.ComponentModel.DataAnnotations;

public class Reservacion {
    public int ReservacionId {get; set;}
    public int HabitacionId {get; set;}
    public int ClienteId {get; set;} 

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:dd-mm-yyyy}", ApplyFormatInEditMode=true)]
    public DateTime InicioReserva {get; set;}

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString= "{0:dd-mm-yyyy}", ApplyFormatInEditMode=true)]
    public DateTime FinReserva {get; set;}

    public int DiasReserva => (FinReserva - InicioReserva).Days;
    
    public Habitacion Habitacion {get; set;}
    public Cliente Cliente {get; set;} 

}