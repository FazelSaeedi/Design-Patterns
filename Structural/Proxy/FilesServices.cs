using System;
using System.IO;

namespace Design_Patterns.Structural.Proxy
{
    class FilesServices : IFilesService
    {
        public DirectoryInfo GetDirectoryInfo(string directoryPath)
        {
            return new DirectoryInfo(directoryPath);
        }

        public void DeleteFile(string fileName)
        {
            File.Delete(fileName);
            Console.WriteLine("the file has been deleted");
        }

        public void WritePersonInFile(string fileName, string name, string lastName, byte age)
        {
            var text = $"my name is {name} {lastName} with {age} years old from dotnettips.info";
            File.WriteAllText(fileName, text);
        }
    }
}
