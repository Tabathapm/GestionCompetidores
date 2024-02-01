using GestionCompetidores.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompetidores.Servicios
{
    public interface ICompetidoresServicio
    {
        List<Competidor> Listar();
        void Agregar(Competidor competidor);
        List<Competidor> ObtenerPorDeporte(int idDeporte);
    }
    public class CompetidoresServicio : ICompetidoresServicio
    {
        public segundoParcialWeb3Context _contexto;

        public CompetidoresServicio(segundoParcialWeb3Context contexto)
        {
            _contexto = contexto;
        }
        
        public List<Competidor> Listar()
        {
            return _contexto.Competidors.ToList();
        }
        
        public void Agregar(Competidor competidor)
        {
            _contexto.Competidors.Add(competidor);
            _contexto.SaveChanges();
        }

        public List<Competidor> ObtenerPorDeporte(int idDeporte)
        {
           return _contexto.Competidors
                .Where(s => s.IdDeporte == idDeporte)
                .ToList();
        }
    }
}
