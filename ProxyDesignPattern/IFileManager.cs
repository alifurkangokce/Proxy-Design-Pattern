using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public interface IFileManager
    { 
        void ReadFile(string fileName);
    }
}
