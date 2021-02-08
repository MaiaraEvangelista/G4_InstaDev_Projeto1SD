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

        private const string PATH = "DataBase/Perfil.csv";

        public Perfil()
        {
            CreateFolderAndFile(PATH);
        }

        public string linha(Perfil y)
        {
                return $"{y.Coments};{y.IdComentarios};{y.Name}";
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
            linhas.RemoveAll(x => x.Split(";")[1] == id.ToString());
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
                perfil.Coments =        sep[0];
                perfil.IdComentarios =  int.Parse(sep[1]);
                perfil.Name =           sep[2];

                perf.Add(perfil);
            }

            return perf;
        }

        public void Update(Perfil y)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll( x => x.Split(";")[1] == y.IdComentarios.ToString() );

            linhas.Add( linha(y) );

            RewriteCSV(PATH , linhas);
        }
    }
}