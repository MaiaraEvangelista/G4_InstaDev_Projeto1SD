using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

        public const string PATH = "Database/Cadastro.csv";

        Cadastro infoscadastro = new Cadastro();

        Perfil perfil = new Perfil();
        Cadastro cadastro = new Cadastro();
        public IActionResult Index()
        {
            ViewBag.Perfil = perfil.ReadAll();
            ViewBag.Cadastros = cadastro.ReadAll();

            ViewBag._UserName = HttpContext.Session.GetString("_UserName");
            ViewBag._Name = HttpContext.Session.GetString("_Name");
            ViewBag._Img = HttpContext.Session.GetString("_Img");
            ViewBag._Email = HttpContext.Session.GetString("_Email");

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

            return Redirect("~/Home/Login");

        }

    }
}