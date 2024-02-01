using System;
using System.Collections.Generic;

namespace GestionCompetidores.Data.EF
{
    public partial class Deporte
    {
        public Deporte()
        {
            Competidors = new HashSet<Competidor>();
        }

        public int IdDeporte { get; set; }
        public string? NombreDeporte { get; set; }

        public virtual ICollection<Competidor> Competidors { get; set; }
    }
}
