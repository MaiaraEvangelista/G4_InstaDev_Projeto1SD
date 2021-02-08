using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace G4_InstaDev_Projeto1SD.Controllers
{

    [Route("Home")]

    public class LoginController : Controller
    {
 
        Cadastro cadastroModel = new Cadastro();
        Login novoLogin = new Login();
        public const string PATH = "Database/Cadastro.csv";

        [TempData]
        public string Mensagem { get; set; }

        [Route("Login")]
        public IActionResult Index() {
            //Index é a tela de login


            return View();
        }

        [Route("Autentic")]
        public IActionResult Login( IFormCollection form ){

            List<string> csv = cadastroModel.ReadAllLinesCSV(PATH);

            var logado = 
            csv.Find(
                x => 
                // x.Split(";")[0] == form["emaildigitado"] ||
                x.Split(";")[0] == form["emaildigitado"] &&
                x.Split(";")[3] == form["senhadigitada"]
            );  

            // Redirecionamos o usuário logado caso encontrado

            if(logado != null)
            {

                HttpContext.Session.SetString("_UserName", logado.Split(";")[2]);
                HttpContext.Session.SetString("_Name", logado.Split(";")[1]);
                HttpContext.Session.SetString("_Img", logado.Split(";")[4]);

                return Redirect("~/Edicao");
  
            }

            Mensagem = "Dados de login incorretos ou não cadastradados,\ntente novamente ou cadastre-se";

            return LocalRedirect("~/Home");

        }
        

        [Route("Logout")]
        public IActionResult Logout(){

            HttpContext.Session.Remove("_UserName");
            HttpContext.Session.Remove("_Name");
            HttpContext.Session.Remove("_Img");

            return Redirect("~/Home/Login");

        }

    }
}