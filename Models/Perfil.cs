using System;
using System.Collections.Generic;
using System.IO;
using G4_InstaDev_Projeto1SD.Interface;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Perfil : SuperClass, IPerfil
    {
        Cadastro cadastro = new Cadastro();

        public int IdComentarios { get; set; }
        public string Coments { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string User { get; set; }

        public void pass()
        {
            cadastro.Nome = Name;
            cadastro.Username = User;
            cadastro.Imagem = Img;
        }

        private const string PATH = "DataBase/Perfil.csv";

        public Perfil()
        {
            CreateFolderAndFile(PATH);
        }

        public string linha(Perfil y)
        {
                return $"{y.Name};{y.User};{y.Img};{y.Coments};{y.IdComentarios};";
        }
        public void Create(Perfil x)
        {
            var lista = ReadAll();

            if (lista.Count > 0)
            {
                Random numale = new Random();
                int numint = numale.Next();

                x.IdComentarios = numint;
            }
            else
            {

                x.IdComentarios = 1;
            }

            string[] lin = { linha(x) };
            File.AppendAllLines(PATH, lin);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[4] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Perfil> ReadAll()
        {
            List<Perfil> perf = new List<Perfil>();
            string[] ler = File.ReadAllLines(PATH);

            foreach (var item in ler)
            {
                string[] sep = item.Split(';');

                Perfil perfil = new Perfil();
                perfil.Name = sep[0];
                perfil.User = sep[1];
                perfil.Img = sep[2];
                perfil.Coments = sep[3];
                perfil.IdComentarios = int.Parse(sep[4]);

                perf.Add(perfil);
            }

            return perf;
        }
    }
}