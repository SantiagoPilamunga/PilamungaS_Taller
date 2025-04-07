using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PilamungaS_Taller.Models;
using PilamungaS_Taller.Repositorios;

namespace PilamungaS_Taller.Controllers
{
    public class EquipoController : Controller
    {

        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuleveListadoEquipos();
            equipos=equipos.OrderByDescending(item => item.PartidosGanados);
            //equipos = equipos.Where(item => item.Nombre == "Liga de quito");
            return View(equipos);
        }


    }
}
