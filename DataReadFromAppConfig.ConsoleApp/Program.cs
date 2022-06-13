using System;
using System.Configuration;

namespace DataReadFromAppConfig.ConsoleApp
{
    class Program
    {
        private static string uniqueKey = ConfigurationManager.AppSettings["UniqueKey"];
        private static string webSite = ConfigurationManager.AppSettings["googleWebSiteKey"];
        private static int number = Convert.ToInt32(ConfigurationManager.AppSettings["numberKey"]);
        static void Main(string[] args)
        {
            Console.WriteLine("Appconfig first key: "+uniqueKey+"\n"+"Appconfig second key: "+webSite + "\n" + "Appconfig fourth key: " + number);
            Console.ReadLine();
        }
    }
}
