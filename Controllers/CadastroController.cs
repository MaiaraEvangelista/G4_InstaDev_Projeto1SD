using System;
using System.IO;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Cadastro")]
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
            novoCadastro.Email = form["Email"];
            novoCadastro.Nome     = form["Nome"];
            novoCadastro.Username = form["Username"];
            novoCadastro.Senha     = form["Senha"];

            Random rnd = new Random();
            novoCadastro.IdUsuario = rnd.Next(1000);

            CadastroModel1.Create(novoCadastro);
            ViewBag.Cadastros = CadastroModel1.ReadAll();

            return LocalRedirect ("~/Cadastro/Listar");
         }

        public IActionResult Excluir (string username){
            CadastroModel1.Remove(username);

            ViewBag.Cadastros = CadastroModel1.ReadAll();

            return LocalRedirect("~/Cadastro/Listar");
        }
    
    }
}