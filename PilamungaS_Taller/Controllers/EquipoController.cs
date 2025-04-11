using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PilamungaS_Taller.Models;
using PilamungaS_Taller.Repositorios;

namespace PilamungaS_Taller.Controllers
{
    

    public class EquipoController : Controller
    {
        
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            
            var equipos = _repository.DevuelveListadoEquipos();
            equipos=equipos.OrderByDescending(item => item.PartidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de quito");
            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        
        public ActionResult Edit(int Id)
        {
            
            Equipo equipo = _repository.DevuelveEquipoPorId(Id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id,Equipo equipo)
        {

            _repository.ActualizarEquipo(Id, equipo);
            return RedirectToAction(nameof(List));

        }
    }
}
