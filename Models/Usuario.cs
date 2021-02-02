using System;
using System.Collections.Generic;
using System.IO;

namespace G4_InstaDev_Projeto1SD.Models 
{
    public class Usuario :CadastroBase
    {
        public int IdUsuario { get; set; }

        public string Nome {get; set;}

        public string Imagem { get; set; }

        public string Email { get; set; }

        public int Deletar{get; set;}

        private const string PATH = "Database/Usuario.csv";

        public Usuario(){
            CreateFolderAndFile(PATH);
        }

        //retirada
        private void CreateFolderAndFile(string pATH)
        {
            throw new NotImplementedException();
        }
    }
}