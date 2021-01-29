namespace G4_InstaDev_Projeto1SD.Models
{
    public class Login
    {
        public string EmailDigitado { get; set; }
        
        public string SenhaDigitada { get; set; }
        
        public string NovaSenha { get; set; }

        public string Validacao { get; set; }
        
        

        // ------------------------------------------------ //
        
        private const string PATH = "Database/Cadastro.csv";

        
        public string ValidacaoEmaileSenha(string EmailDigitado, string email, string SenhaDigitada, string senha){

            //  Coletar as informações presentes no CSV de cadastro
            string linhas = ReadAllLines(PATH);

            //  Percorrer as linhas do CSV
            foreach (var linha in linhas)
            {
                
                //  Atribuir o valor do email correspondente no CSV a uma váriavel para fazer a comparação
                string [] email = linha.Split(";")[0];

                //  Atribuir o valor da senha correspondedo no CSV a uma váriavel para fazer a comparação
                string [] senha = linha.split(";")[3];

                // verificar se o email E senha digitado correspondem a algum email e senha presente na mesma Linha
                if (email == EmailDigitado && senha == SenhaDigitada )
                {
                    
                    //  Se ele encontrar retorna o valor verdadeiro
                    Validacao == "Login Localizado";

                }

            }

            //  Se não encontrar retorna falso, e a utilização desses dados serão representados no cshtml
            Validacao == "Email ou Senha Incorretos, caso";

        }   
        
    }
}