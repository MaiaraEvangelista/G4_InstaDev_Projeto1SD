using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{

    [Route("Home")]
    public class LoginController : Controller
    {
        Login novoLogin = new Login();

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
        
    }
}