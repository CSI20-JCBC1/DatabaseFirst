using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Asignatura
    {
        public Asignatura()
        {
            ListaAlumnos = new HashSet<Alumno>();
        }

        public int Id { get; set; }
        public string AsignaturaNombre { get; set; } = null!;

        public virtual ICollection<Alumno> ListaAlumnos { get; set; }
    }
}
