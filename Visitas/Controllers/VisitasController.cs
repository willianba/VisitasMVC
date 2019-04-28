using ApresentacaoVisitas.BLL;
using ApresentacaoVisitas.DB.Data;
using ApresentacaoVisitas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApresentacaoVisitas.Controllers
{
    public class VisitasController : Controller
    {
        private VisitasFacade visitasFachada = VisitasFacade.getInstance();

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Visitante visitante)
        {
            visitasFachada.cadastrar(visitante);
            return View("List");
        }

        public IActionResult List()
        {
            return View(visitasFachada.buscarVisitantes());
        }
    }
}