using System.IO;


namespace DependencyInjection.Services
{
    public interface IFileService
    {
        public List<string> GetFileName();
       
    }
    public class FileService:IFileService
    {
        public List<string> GetFileName()
        {
            return new List<string>()
            {

                "note.txt",
                "file.file",
                "muzik.mp3",
                "password.txt"

            };


        }
    }
}
