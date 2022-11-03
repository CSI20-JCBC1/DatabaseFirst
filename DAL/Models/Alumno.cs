using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            ListaAsignaturas = new HashSet<Asignatura>();
        }

        public int Id { get; set; }
        public string AlumnoNombre { get; set; } = null!;
        public string AlumnoApellidos { get; set; } = null!;
        public string AlumnoEmail { get; set; } = null!;

        public virtual ICollection<Asignatura> ListaAsignaturas { get; set; }
    }
}
