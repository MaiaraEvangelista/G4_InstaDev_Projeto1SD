using System.IO;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    public class CadastroController :Controller
    {
        Cadastro CadastroModel = new Cadastro (); 

        [Route("Listar")]
        public IActionResult Index (){
            ViewBag.Cadastros = CadastroModel.ReadAll();
            return View(); 
        }

        [Route ("Cadastrar")]
        public IActionResult Cadastrao (IFormCollection form){
            Cadastro novoCadastro   = new Cadastro();
            novoCadastro.Username = form["Username"];
            novoCadastro.Nome     = form["Nome"];

            CadastroModel.Create(novoCadastro);
            ViewBag.Cadastros = CadastroModel.ReadAll();

            return LocalRedirect ("~/Cadastro");
         }

         [Route("{username}")]
        public IActionResult Excluir (string username){
            CadastroModel.Remove(username);

            ViewBag.Cadastros = CadastroModel.ReadAll();

            return LocalRedirect("~/Cadastro/Listar");
        }
    
    }
}