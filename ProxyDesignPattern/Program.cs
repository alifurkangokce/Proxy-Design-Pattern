// Proxy kullanımı
using ProxyDesignPattern;

IFileManager fileManager = new FileManagerProxy();
fileManager.ReadFile("example.txt");

Console.ReadLine();
