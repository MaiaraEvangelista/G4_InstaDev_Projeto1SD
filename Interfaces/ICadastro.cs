using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;

namespace G4_InstaDev_Projeto1SD.Interfaces
{
    public interface ICadastro
    {
         void Create (Cadastro c);
         void Remove (string username);
         List<Cadastro> ReadAll();
         void Uptade ();
    }
}