using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;

namespace G4_InstaDev_Projeto1SD.Interface
{
    public interface IPerfil
    {
         void Create(Perfil x);
        List<Perfil> ReadAll();
        void Delete(int id);
        void Update(Perfil y);
    }
}