using ConsoleApp1.Manager;
using ConsoleApp1.Model;
using ConsoleApp1.WebService;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Main class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Args values.</param>
        public static void Main(string[] args)
        {
            //TestLegume();

            TestWebService();
            //TestAsync();

            Console.ReadLine();
        }

        private static void TestLegume()
        {
            Navet leBonNavet = new Navet("roger", 10);
            leBonNavet.Grandir();

            Console.WriteLine(leBonNavet.Couper(5).Name);

            Legume rutabaga = new Rutabaga("le rut", 5);

            Console.WriteLine(rutabaga.Name);

            (rutabaga as Rutabaga).Consumption = DateTime.Now;

            Console.WriteLine((rutabaga as Rutabaga).Consumption);

            List<Legume> legumes = new List<Legume>();
            legumes.Add(leBonNavet);
            legumes.Add(rutabaga);

            foreach (var item in legumes)
            {
                if (item is Navet)
                {
                    Console.WriteLine("C'est un Navet");
                }
                else if (item is Rutabaga)
                {
                    Console.WriteLine("C'est un Rutabaga");
                }
            }

            Dictionary<String, Object> monDico = new Dictionary<string, object>();
            monDico.Add("legume1", leBonNavet);
            monDico.Add("legume2", rutabaga);

            foreach (KeyValuePair<string, object> item in monDico)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Object dicoVal = monDico["legume1"];

            LegumeManager<Navet> navetManager = new LegumeManager<Navet>();
            foreach (var item in navetManager.Cultiver())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void TestAsync()
        {
            Action a1 = new Action(() =>
            {
                int i = 0;
                while (true)
                {
                    Console.WriteLine(i);
                    i++;
                }
            });

            Func<int, int, Boolean> f1 = new Func<int, int, bool>((a, b) =>
            {
                return true;
            });

            f1.Invoke(1, 2);

            Task.Factory.StartNew(a1);
        }

        public static async void TestWebService()
        {
            WebServiceManager<User> webServiceManager = new WebServiceManager<User>("https://jsonplaceholder.typicode.com/");
            User toSet = await webServiceManager.HttpClientCaller<User>("https://jsonplaceholder.typicode.com/users/1");
            Console.WriteLine(toSet);
            JObject obj = await webServiceManager.HttpClientCaller("https://jsonplaceholder.typicode.com/users/1");
            Console.WriteLine(obj);
        }
    }
}
