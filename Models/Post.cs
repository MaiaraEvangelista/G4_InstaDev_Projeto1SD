using System;
using System.IO;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Postar
    {
        public string Legenda { get; set; }
        public string Imagem { get; set; }
        private const string PATH = "Database/Post.csv";
        public Postar()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Postar p)
        {
            return $"{p.Legenda};{p.Imagem}";
        }
        public void Create(Postar p)
        {
            string[] linhas = { Prepare(p) };
            File.AppendAllLines(PATH, linhas);
        }
    }
}