using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{

    [Route("Home")]
    public class LoginController : Controller
    {
        Login novoLogin = new Login();
        Cadastro newCadastro = new Cadastro();

        [Route("Login")]
        public IActionResult Index() {
            //Index é a tela de login

            return View();
        }

        [Route("Autenticacao")]
        public IActionResult Login( IFormCollection form ){

            novoLogin.EmailDigitado = form["emaildigitado"];
            novoLogin.SenhaDigitada = form["senhadigitada"];

            if(novoLogin.ValidacaoEmaileSenha( novoLogin.EmailDigitado, novoLogin.SenhaDigitada ) == true) {

                // return a pagina feed

                return LocalRedirect("~/Feed");

            }

            return LocalRedirect("~/Home/Login");
        
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {


            // Lemos todos os arquivos do CSV
            List<string> csv = newCadastro.ReadAllLinesCSV("Database/Cadastro.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[2] == form["Email"] && 
                x.Split(";")[3] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {

                HttpContext.Session.SetString("_IdUsuario", logado.Split(";")[0]);

                return LocalRedirect("~/");
            }

            novoLogin.Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Login");
        }
        
    }
}