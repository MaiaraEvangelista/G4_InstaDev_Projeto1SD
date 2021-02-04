using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;

namespace G4_InstaDev_Projeto1SD.Interfaces
{
    public interface IPost
    {
        void Create(Postar p);
        List<Postar> ReadAll();
    }
}