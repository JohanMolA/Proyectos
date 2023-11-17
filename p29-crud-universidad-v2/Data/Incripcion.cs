public class Inscripcion {
    public int InscripcionId {get; set;}
    public int CursoId {get; set;} //llave secundaria relacion muchos a uno, tabla curso
    public int EstudianteId {get; set;} //llave secundaria relacion muchos a uno, tabla estudiante
    public float? Promedio {get; set;}

    public Curso Curso {get; set;} //Detalle de la relacion muchos a uno
    public Estudiante Estudiante {get; set;} //Detalle de la relacion muchos a uno
}