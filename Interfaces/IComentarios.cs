using System.Collections.Generic;
using G4_InstaDev_Projeto1SD.Models;

namespace G4_InstaDev_Projeto1SD.Interfaces
{
    public interface IComentarios
    {
        void Create(Comentarios c);
        List<Comentarios> ReadAll();
        void Update(Comentarios c);
        void Delete(int Id);
    }
}