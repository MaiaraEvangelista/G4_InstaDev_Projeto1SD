using System.IO;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class Login
    {
        public string EmailDigitado { get; set; }
        
        public string SenhaDigitada { get; set; }
        
        public string UsernameDigitado {get; set;}
        
        public string NovaSenha { get; set; }

        public string Validacao { get; set; }
        
        

        // ------------------------------------------------ //
        
        // private const string PATH = "Database/Cadastro.csv";

        
        // public bool ValidacaoEmaileSenha(string EmailDigitado, string SenhaDigitada ){
            
        //     //  Coletar as informações presentes no CSV de cadastro
        //     string [] linhas = File.ReadAllLines(PATH);

        //     //  Percorrer as linhas do CSV
        //     foreach (var dado in linhas)
        //     {
                
        //         //  Atribuir o valor do email correspondente no CSV a uma váriavel para fazer a comparação
        //         string emailCSV = dado.Split(";")[0];

        //         //  Atribuir o valor da senha correspondedo no CSV a uma váriavel para fazer a comparação
        //         string senhaCSV = dado.Split(";")[3];

        //         // verificar se o email E senha digitado correspondem a algum email e senha presente na mesma Linha
        //         if (emailCSV == EmailDigitado && senhaCSV == SenhaDigitada )
        //         {
                    

        //             //  Se ele encontrar retorna o valor verdadeiro
        //             Validacao = "Login Localizado";


        //             return true;
                    
        //         }

        //     }

        //     //  Se não encontrar retorna falso, e a utilização desses dados serão representados no cshtml
        //     Validacao = "Email ou Senha Incorretos";

        //     return false;

        // }   
        
    }
}