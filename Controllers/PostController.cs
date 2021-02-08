using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Feed")]
    public class PostController : Controller
    {
        Postar postModel = new Postar();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Post = postModel.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Postar novoPostar = new Postar();
            novoPostar.IdPost = int.Parse( form["IdPost"] );
            novoPostar.Legenda = form["Legenda"];
            novoPostar.Imagem = form["Imagem"];

            postModel.Create( novoPostar );
            ViewBag.Postar = postModel.ReadAll();

            return LocalRedirect("~/Feed");
        }

    }
}