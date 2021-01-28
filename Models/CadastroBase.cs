using System.IO;

namespace G4_InstaDev_Projeto1SD.Models
{
    public class CadastroBase
    {
        public void CreateFolderAndFile (string path){
            string folder = path.Split(";")[0];

            if(Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }
            if(File.Exists(path)){
                File.Create(path);
            }
        }
    }
}