using System.IO;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    public class CadastroController :Controller
    {
        Cadastro CadastroModel1 = new Cadastro (); 

        [Route("Listar")]
        public IActionResult Index (){
            ViewBag.Cadastros = CadastroModel1.ReadAll();
            return View(); 
        }

        [Route ("Cadastrar")]
        public IActionResult Cadastrao (IFormCollection form){
            Cadastro novoCadastro   = new Cadastro();
            novoCadastro.Username = form["Email"];
            novoCadastro.Nome     = form["Nome"];
            novoCadastro.Username = form["Username"];
            novoCadastro.Nome     = form["Senha"];

            CadastroModel1.Create(novoCadastro);
            ViewBag.Cadastros = CadastroModel1.ReadAll();

            return LocalRedirect ("~/Cadastro");
         }

         [Route("{Id}")]
        public IActionResult Excluir (string username){
            CadastroModel1.Remove(username);

            ViewBag.Cadastros = CadastroModel1.ReadAll();

            return LocalRedirect("~/Cadastro/Listar");
        }
    
    }
}