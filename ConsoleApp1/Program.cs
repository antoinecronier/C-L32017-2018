using ConsoleApp1.Model;
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

            Console.ReadLine();
        }
    }
}
