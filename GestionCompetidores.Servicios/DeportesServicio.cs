using GestionCompetidores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompetidores.Servicios
{
    public interface IDeportesServicio
    {
        List<Deporte> Listar();
    }
    public class DeportesServicio : IDeportesServicio
    {
        public segundoParcialWeb3Context _contexto;

        public DeportesServicio(segundoParcialWeb3Context contexto)
        {
            _contexto = contexto;
        }

        public List<Deporte> Listar()
        {
            return _contexto.Deportes
            .OrderBy(c => c.NombreDeporte)
            .ToList();
        }

    }
}
