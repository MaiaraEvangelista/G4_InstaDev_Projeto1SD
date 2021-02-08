using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Edição")]
    public class EdicaoController : Controller
    {
        Perfil perfil = new Perfil();

        public IActionResult Index()
        {
            ViewBag.Edicao = perfil.ReadAll();
            return View();
        }
    }
}