using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LlamadoPacientes.Models;
using LlamadoPacientes.Models.Repository;

namespace LlamadoPacientes.Controllers
{
    public class HomeController : Controller
    {
        private AtencionRepository atencionRepository;

        public List<Atencion> listAtencion { get; set; }
        public List<Atencion> listAtencionCarrusel { get; set; }

        public ActionResult Index()
        {
            this.loadAtenciones();
            this.loadCarrusel();
            ViewBag.listaAtencion = this.listAtencion;
            ViewBag.listaCarrusel = this.listAtencionCarrusel;

            return View();
        }

        private void loadCarrusel()
        {
            atencionRepository = new AtencionRepository();
            listAtencionCarrusel = atencionRepository.listAtencionesCarrusel();
        }

        private void loadAtenciones()
        {
            atencionRepository = new AtencionRepository();
            listAtencion = atencionRepository.listUltimasAtenciones();
            
        }
        
    }
}