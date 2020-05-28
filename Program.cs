using System;
using System.IO;

namespace SeleniumCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var aa = new Initialize();
            //aa.FirstTest();
            
            string name = @"\chromedriver.exe";
            string path = Directory.GetCurrentDirectory() ;
            path += name;
            var aa = new Initialize();
            aa.FirstTest(path);
            Console.WriteLine(path);
        }
    }
}
