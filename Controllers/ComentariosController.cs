using System;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Coment")]
    public class ComentariosController : Controller
    {
        Comentarios comentModel = new Comentarios();

        public IActionResult Index()
        {
            ViewBag.Comentario = comentModel.ReadAll(); 
            return View();
        }

        [Route("Comentar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Comentarios novoComentar = new Comentarios();
            novoComentar.Comentario = form["Comentario"];

            comentModel.Create( novoComentar );
            ViewBag.Comentarios = comentModel.ReadAll();

            return LocalRedirect("~/Feed");
        }
    }
}