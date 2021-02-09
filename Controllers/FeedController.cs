using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Postar postModel = new Postar();
        Comentarios comentModel = new Comentarios();

        public IActionResult Index()
        {
            ViewBag.Post = postModel.ReadAll();
            ViewBag.Comentario = comentModel.ReadAll(); 
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Postar novoPostar = new Postar();
            novoPostar.Legenda = form["Legenda"];
            novoPostar.Imagem = form["Imagem"];


            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
   
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                novoPostar.Imagem = file.FileName;
            }

            novoPostar.Legenda = form["Legenda"];
           
            postModel.Create(novoPostar);
            
           
            return LocalRedirect("~/Feed");

        }

        [Route("Comentario")]
        public IActionResult CadastrarComentario(IFormCollection form)
        {
            Comentarios novoComentar = new Comentarios();
            novoComentar.Comentario = form["Comentario"];

            comentModel.Create( novoComentar );
            ViewBag.Comentarios = comentModel.ReadAll();

            return LocalRedirect("~/Feed");
        }

    }
}