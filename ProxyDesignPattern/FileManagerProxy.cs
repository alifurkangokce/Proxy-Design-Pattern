using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class FileManagerProxy : IFileManager
    {
        private FileManager realFileManager;

        public void ReadFile(string fileName)
        {
            // FileManager sınıfını sadece ihtiyaç duyulduğunda oluştur
            if (realFileManager == null)
            {
                realFileManager = new FileManager();
            }

            // Dosya okuma yetkisi kontrolü
            if (UserAuthentication.IsUserAuthenticated())
            {
                Console.WriteLine("Kullanıcı yetkilendirildi.");
                // dosya işleme sınıfını çağır
                realFileManager.ReadFile(fileName);
            }
            else
            {
                Console.WriteLine("Kullanıcı yetkilendirilmedi. Dosya okunamıyor.");
            }
        }
    }
}
