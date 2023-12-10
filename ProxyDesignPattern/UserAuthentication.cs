using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // Kullanıcı yetkilendirme sınıfı
    public static class UserAuthentication
    {
        public static bool IsUserAuthenticated()
        {
            // Kullanıcı yetkilendirme mantığı burada olacak
            // Gerçek bir uygulamada karmaşık bir yetkilendirme mekanizması kullanılır.
            return true;
        }
    }
}
