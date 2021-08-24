using Newtonsoft.Json;
using quotes.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string res = wc.DownloadString("https://quotes.rest/qod");
            Root root = JsonConvert.DeserializeObject<Root>(res);
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
