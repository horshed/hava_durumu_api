using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace api2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string api= "89558ddd00371adfaa8d24417e2da411";
            string bag = "https://api.openweathermap.org/data/2.5/weather?q=Antalya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava= XDocument.Load(bag);
            var temp = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            Console.WriteLine("Antalya Hava Durumu   "+temp);
            Console.Read();


        }
    }
}
