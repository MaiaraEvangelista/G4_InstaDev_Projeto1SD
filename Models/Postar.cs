using System;
using System.Collections.Generic;
using System.IO;
using G4_InstaDev_Projeto1SD.Interfaces;

namespace G4_InstaDev_Projeto1SD.Models  
{
    public class Postar : PostBase , IPost
    {
        public int IdPost { get; set; }
        public string Legenda { get; set; }
        public string Imagem { get; set; }
        private const string PATH = "Database/Post.csv";
        public Postar()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Postar p)
        {
            return $"{p.IdPost};{p.Legenda};{p.Imagem}";
        }
        public void Create(Postar p)
        {
            var lista = ReadAll();

            Random aleatorio = new Random();

            if (lista.Count > 0)
            {
                Random numeroAleatorio = new Random();
                int numeroInteiro = numeroAleatorio.Next();

                p.IdPost = numeroInteiro;
            } else 
            {
                p.IdPost = 1;
            }


            string[] linhas = { Prepare(p) };
            File.AppendAllLines(PATH, linhas);
        }

        public List<Postar> ReadAll()
        { 
            List<Postar> postagem = new List<Postar>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                //1;Legenda;Imagem.jpg
                string[] linha = item.Split(";");

                //[0] = 1
                //[1] = Legenda
                //[2] = Imagem.jpg

                Postar novoPost = new Postar();

                novoPost.IdPost = int.Parse( linha[0] );
                novoPost.Legenda = linha[1];
                novoPost.Imagem = linha[2];

                postagem.Add(novoPost);
            }

            return postagem;
        }

        public void Update(Postar p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll( x => x.Split(";")[0] == p.IdPost.ToString() );

            linhas.Add( Prepare(p) );

            RewriteCSV(PATH , linhas);
        }

        public void Delete(int Id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(";") [0] == Id.ToString() );

            RewriteCSV(PATH , linhas);
        }
    }
}