using System;
using System.Collections.Generic;
using System.IO;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nome {get; set;}

        public string Imagem { get; set; }

        public string Email { get; set; }

        public int Deletar{get; set;}

        private const string PATH = "Database/Equipe.csv";

         public Usuario()
         {
            // CreateFolderAndFile(PATH);
         }

         public void Create(Usuario u)
         {
             string[] linhas = {};
             File.AppendAllLines(PATH, linhas);
         }

        

       

        public void Delete(int id)
         {
           //  List<string> linhas = ReadAllLineCSV();
           //  {
           //      linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
                
           //  }            
         }

       

       

      
    }
}