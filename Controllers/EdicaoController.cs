using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{

    [Route("Edicao")]
    public class EdicaoController : Controller
    {
        public const string PATH = "Database/Cadastro.csv";
        Cadastro infoscadastro = new Cadastro();
        
        public IActionResult Index(){

            return View();

        }
    
    
        [Route("Atualizar")]
        public IActionResult Update (IFormCollection forms){

            List<string> csv = infoscadastro.ReadAllLinesCSV(PATH);

            var perfil =
            csv.Find(
                x => 
                x.Split(";")[2] == ViewBag._UserName &&
                x.Split(";")[1] == ViewBag._Name &&
                x.Split(";")[0] == ViewBag._Email
            );  

            if (perfil != null)
            {
                
                perfil.Split(";")[2] = forms["newusername"];
                perfil.Split(";")[1] = forms["newname"];
                perfil.Split(";")[0] = forms["newemail"];


                HttpContext.Session.SetString("_UserName", perfil.Split(";")[2]);
                HttpContext.Session.SetString("_Name", perfil.Split(";")[1]);
                HttpContext.Session.SetString("_Email", perfil.Split(";")[0]);

                infoscadastro.Nome = forms ["newusername"];
                infoscadastro.Nome = forms ["newname"];
                infoscadastro.Email = forms ["newemail"];
                
                infoscadastro.Uptade( infoscadastro );

            }

            return Redirect("~/Perfil");

        }
    
    }
}