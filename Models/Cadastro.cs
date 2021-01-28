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

        private const string PATH = "Database/Cadastro.csv";

        public string Prepare (Cadastro c){
            return $"{c.Email}, {c.Nome}, {c.Username}, {c.Senha}";
        }
        public Cadastro (){
            CreateFolderAndFile(PATH);
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
                
            }
            return cadastros;
        }

        public void Remove(string username)
        {
            throw new System.NotImplementedException();
        }

        public void Uptade()
        {
            throw new System.NotImplementedException();
        }
    }
}