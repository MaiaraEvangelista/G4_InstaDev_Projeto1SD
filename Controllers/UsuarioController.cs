using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    public class UsuarioController : Controller
    {
        Cadastro usuarioModel = new Cadastro();

         
        //observar se realmente será necessária 
        public IActionResult Index()
        {
           
            ViewBag.IdUsuario = HttpContext.Session.GetString("_IdUsuario"); 

            return View();
        }

        public IActionResult Alterar(IFormCollection form)
        {
            Cadastro novoCadastro   = new Cadastro();

            novoCadastro.IdUsuario = ViewBag.IdUsuario();
            novoCadastro.Email = form["Email"];
            novoCadastro.Nome     = form["Nome"];
            novoCadastro.Username = form["Username"];
            novoCadastro.Senha     = form["Senha"];

            usuarioModel.Uptade(novoCadastro);

            return LocalRedirect("~/Home/Index"); 
        }

      
    }
}