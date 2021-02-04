using System.Collections.Generic;
using System.IO;
using G4_InstaDev_Projeto1SD.Interfaces;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Cadastro : CadastroBase, ICadastro 
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        private string imagem = "padrao.png";
        public string Imagem { get {return imagem;} set{imagem = value;}}

        public const string PATH = "Database/Cadastro.csv";

        public string Prepare (Cadastro c){
            return $"{c.Email};{c.Nome};{c.Username};{c.Senha};{c.Imagem}";
        }
        public Cadastro (){
            CreateFileAndFolder(PATH);
        }

        public void Create(Cadastro c)
        {
            string [] linhas = {Prepare(c)};
            File.AppendAllLines(PATH, linhas);
        }

        public List<Cadastro> ReadAll()
        {
            List<Cadastro> cadastros = new List<Cadastro> ();
            string [] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string [] linha = item.Split (";");
                Cadastro cadastro = new Cadastro ();

                cadastro.Email    = linha[0];
                cadastro.Nome     = linha[1];
                cadastro.Username = linha[2];
                cadastro.Senha    = linha[3];

                cadastros.Add(cadastro);

            }
            return cadastros;
        }

        public void Remove(string username)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x=> x.Split(";")[0] == username.ToString());
            RewriteCSV (PATH, linhas);
        }

        public void Uptade(Cadastro c)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x=> x.Split(";")[0] == c.Username.ToString());
            linhas.Add(Prepare (c));
            RewriteCSV (PATH, linhas);

        }
    }
}