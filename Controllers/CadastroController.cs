using System;
using System.Collections.Generic;
using System.IO;
using G4_InstaDev_Projeto1SD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    [Route("Cadastro")]
    public class CadastroController :Controller
    {
        Cadastro CadastroModel1 = new Cadastro (); 
        public const string PATH = "Database/Cadastro.csv";
        
        [TempData]
        public string errorcad { get; set; }
        
        

        [Route("Listar")]
        public IActionResult Index (){
            ViewBag.Cadastros = CadastroModel1.ReadAll();
            return View(); 
        }

        [Route ("Cadastrar")]
        public IActionResult Cadastrao (IFormCollection form){
            Cadastro novoCadastro   = new Cadastro();
            
            novoCadastro.Email  = form["Email"];
            novoCadastro.Nome     = form["Nome"];
            novoCadastro.Username = form["Username"];
            novoCadastro.Senha     = form["Senha"];

            if( form.Files.Count > 0){
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Perfis");
        
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream (path, FileMode.Create)){
                    file.CopyTo(stream);
                }

                novoCadastro.Imagem = file.FileName;
            } 
            else {
            
                novoCadastro.Imagem = "padrao.png";
            
            }

        
            ViewBag.Cadastros = CadastroModel1.ReadAll();

            List<string> cadastrocsv = CadastroModel1.ReadAllLinesCSV(PATH);

            var cadastrado = 
            cadastrocsv.Find(
                x => 
                x.Split(";")[0] == form["Email"] || 
                x.Split(";")[2] == form["Username"]
            );


            if ( cadastrado == null )
            {

                CadastroModel1.Create(novoCadastro);
                ViewBag.Cadastros = CadastroModel1.ReadAll();

                return Redirect ("~/Home/Login");

            } else {


                Console.WriteLine($"criado");



                Console.WriteLine("nao criado");

                errorcad = "Cadastro já existente, Insira um email e usuario válido e tente novamente";

                return LocalRedirect("/Cadastro/Listar");
            }
            
        }
    
    }
}