using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{

    [Route("Home")]

    public class LoginController : Controller
    {
        Cadastro cadastroModel = new Cadastro();
        Login novoLogin = new Login();
        public const string PATH = "Database/Cadastro.csv";


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
                x.Split(";")[0] == form["emaildigitado"] && 
                x.Split(";")[3] == form["senhadigitada"]
            );  

            // Redirecionamos o usuário logado caso encontrado

            if(logado != null)
            {

                HttpContext.Session.SetString("_UserName", logado.Split(";")[2]);
                cadastroModel.Nome = logado.Split(";"[1]).ToString();
                cadastroModel.Username = logado.Split(";"[2]).ToString();
                cadastroModel.Imagem = logado.Split(";"[4]).ToString();
                cadastroModel.Email = logado.Split(";"[0]).ToString();
                
                return Redirect("~/Perfil");
  
            }

            // novoLogin.Validacao = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Home");

        }
        
    }
}