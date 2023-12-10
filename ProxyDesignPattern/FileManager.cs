using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // Gerçek nesne
    public class FileManager : IFileManager
    {
        public void ReadFile(string fileName)
        {
            Console.WriteLine($"Dosya okunuyor: {fileName}");
            // Dosya okuma işlemleri burada gerçekleştirilir.
        }
    }
}
