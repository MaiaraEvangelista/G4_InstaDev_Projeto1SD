using System;
using System.Collections.Generic;
using System.IO;
using G4_InstaDev_Projeto1SD.Interfaces;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Comentarios : PostBase , IComentarios
    {
        public int IdComentario { get; set; }
        public string Comentario { get; set; }
        private const string PATH = "Database/Comentario.csv";

        public Comentarios()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Comentarios c)
        {
            return $"{c.IdComentario};{c.Comentario}";
        }

        public void Create(Comentarios c)
        {
            var listaComentario = ReadAll();

            Random aleatorioComentario = new Random();

            if (listaComentario.Count > 0)
            {
                Random numeroAleatorioComentario = new Random();
                int numeroInteiroComentario = numeroAleatorioComentario.Next();

                c.IdComentario = numeroInteiroComentario;
            } else 
            {
                c.IdComentario = 1;
            }


            string[] linhasComentario = { Prepare(c) };
            File.AppendAllLines(PATH, linhasComentario);
        }

        public List<Comentarios> ReadAll()
        {
            List<Comentarios> comentario = new List<Comentarios>();
            string[] linhasComentario = File.ReadAllLines(PATH);

            foreach (var item in linhasComentario)
            {
                //1;Comentario;
                string[] linhaComentario = item.Split(";");

                //[0] = 1
                //[1] = Comentario

                Comentarios novoComentario = new Comentarios();

                novoComentario.IdComentario = int.Parse( linhaComentario[0] );
                novoComentario.Comentario = linhaComentario[1];

                comentario.Add(novoComentario);
            }

            return comentario;
        }

        public void Update(Comentarios c)
        {
            List<string> linhasComentario = ReadAllLinesCSV(PATH);

            linhasComentario.RemoveAll( x => x.Split(";")[0] == c.IdComentario.ToString() );

            linhasComentario.Add( Prepare(c) );

            RewriteCSV(PATH , linhasComentario);
        }

        public void Delete(int Id)
        {
            List<string> linhasComentario = ReadAllLinesCSV(PATH);

            linhasComentario.RemoveAll(x => x.Split(";") [0] == Id.ToString() );

            RewriteCSV(PATH , linhasComentario);
        }
    }
}