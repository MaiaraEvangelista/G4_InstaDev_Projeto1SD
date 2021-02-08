using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Perfil perfil = new Perfil();
        Cadastro cadastro = new Cadastro();
        public IActionResult Index()
        {
            ViewBag.Perfil = perfil.ReadAll();
            ViewBag.Cadastros = cadastro.ReadAll();

            ViewBag._UserName = HttpContext.Session.GetString("_UserName");
            ViewBag._Name = HttpContext.Session.GetString("_Name");
            ViewBag._Img = HttpContext.Session.GetString("_Img");

            return View();
        }
        [Route("Comentar")]
        public IActionResult Comentar(IFormCollection form)
        {
            Perfil newperfil = new Perfil();
            newperfil.Coments= form["comentario"];
            newperfil.Name= form["Nomes"];

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