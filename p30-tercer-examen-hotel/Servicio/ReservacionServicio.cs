// Servicios/ReservacionServicio.cs
using Microsoft.EntityFrameworkCore;

public class ReservacionServicio {
    private readonly ContextoDatos ctx;
    public ReservacionServicio(ContextoDatos contexto) => ctx = contexto;

    public List<Reservacion> ObtenerTodo() {
        return ctx.Reservaciones
        .Include(e=>e.Cliente)
        .Include(c=>c.Habitacion)
        .ToList();
    }
    
    public bool AgregarActualizar(Reservacion reservacion) {
        try {
            if (reservacion.ReservacionId == 0) ctx.Reservaciones.Add(reservacion);
            else ctx.Reservaciones.Update(reservacion);
            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }
    
    public Reservacion EcontrarPorId(int Id) {
        return ctx.Reservaciones.Find(Id);
    }
    
    public bool Borrar(int id) {
        try {
            var reservacion = EcontrarPorId(id);
            if(reservacion==null) return false;
            else ctx.Reservaciones.Remove(reservacion);
            ctx.SaveChanges();
            return true;
        } catch (Exception ex) { return false; }
    }
}