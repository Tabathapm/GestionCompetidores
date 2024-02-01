using GestionCompetidores.Data.EF;
using GestionCompetidores.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionCompetidores.Web.Controllers
{
    public class CompetidorController : Controller
    {
        private IDeportesServicio _deportesServicio;
        private ICompetidoresServicio _competidoresServicio;

        public CompetidorController(IDeportesServicio deportesesServicio, ICompetidoresServicio competidoresServicio) 
        {
            _competidoresServicio = competidoresServicio;
            _deportesServicio = deportesesServicio;
        }

        public ActionResult Agregar()
        {
            ViewBag.Deportes = _deportesServicio.Listar();
            return View(new Competidor());
        }

        [HttpPost]
        public ActionResult Agregar(Competidor competidor)
        {
            _competidoresServicio.Agregar(competidor);
            return RedirectToAction("Listar");
        }


        public ActionResult Listar(int? idDeporte)
        {
            ViewBag.Deportes = _deportesServicio.Listar();
            ViewBag.IdDeporteSeleccionado = idDeporte;
            if (idDeporte.HasValue)
            {
                return View(_competidoresServicio.ObtenerPorDeporte(idDeporte.Value));
            }
            return View(_competidoresServicio.Listar());
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
