using System;
using System.IO;

namespace Design_Patterns.Structural.Proxy
{
    class FilesServicesProxy : IFilesService
    {
        private readonly IFilesService _filesService;

        public FilesServicesProxy()
        {
            _filesService = new FilesServices();
        }

        public DirectoryInfo GetDirectoryInfo(string directoryPath)
        {
            var existing = Directory.Exists(directoryPath);
            if (!existing)
                Directory.CreateDirectory(directoryPath);
            return _filesService.GetDirectoryInfo(directoryPath);
        }

        public void DeleteFile(string fileName)
        {
            if (!File.Exists(fileName))
                Console.WriteLine("Please enter a valid path");
            else
                _filesService.DeleteFile(fileName);
        }

        public void WritePersonInFile(string fileName, string name, string lastName, byte age)
        {
            if (!Directory.Exists(fileName.Remove(fileName.LastIndexOf("\\"))))
            {
                Console.WriteLine("File Path is not valid");
                return;
            }
            if (name.Trim().Length == 0)
            {
                Console.WriteLine("first name must enter");
                return;
            }

            if (lastName.Trim().Length == 0)
            {
                Console.WriteLine("last name must enter");
                return;
            }

            if (age < 18)
            {
                Console.WriteLine("your age is illegal");
                return;
            }


            if (name.Trim().Length < 3)
            {
                Console.WriteLine("first name must be more than 2 letters");
                return;
            }

            if (lastName.Trim().Length < 5)
            {
                Console.WriteLine("last name must be more than 4 letters");
                return;
            }

            _filesService.WritePersonInFile(fileName, name, lastName, age);
            Console.WriteLine("the file has been written");
        }
   
    }
}
