using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Perfil perfil = new Perfil();
        public IActionResult Index()
        {
            ViewBag.Perfil = perfil.ReadAll();
            return View();
        }
        [Route("Comentar")]
        public IActionResult Comentar(IFormCollection form)
        {
            Perfil newperfil = new Perfil();
            newperfil.Coments= form["comentario"];

            perfil.Create(newperfil);
            ViewBag.Perfil = perfil.ReadAll();

            return LocalRedirect("~/Perfil");
        }

        [Route("Perfil/{id}")]
        public IActionResult Excluir(int id)
        {
            perfil.Delete(id);
            ViewBag.Perfil = perfil.ReadAll();
            return LocalRedirect("~/Perfil");
        }
    }
}