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

            postModel.Create( novoPostar );
            ViewBag.Postar = postModel.ReadAll();

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