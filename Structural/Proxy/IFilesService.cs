using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Proxy
{
    public interface IFilesService
    {
        DirectoryInfo GetDirectoryInfo(string directoryPath);
        void DeleteFile(string fileName);
        void WritePersonInFile(string fileName, string name, string lastName, byte age);
    }
}
