using System.ComponentModel.DataAnnotations;
public class Inscripcion
{
    public int InscripcionId { get; set; }
    public int CursoId { get; set; }
    //llave secundaria muchos a uno
    public int EstudianteId { get; set; }
    public float? Promedio { get; set; }
    public Curso Curso { get; set; }
    public Estudiante Estudiante { get; set; }
}