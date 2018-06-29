using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Manager
{
    /// <summary>
    /// LegumeManager.
    /// </summary>
    public class LegumeManager<T> where T : Legume
    {
        /// <summary>
        /// Cultiver.
        /// </summary>
        /// <returns>List de legume.</returns>
        public List<T> Cultiver()
        {
            List<T> cutures = new List<T>();

            for (int i = 0; i < 10; i++)
            {
                cutures.Add((T)Activator.CreateInstance(typeof(T),"name"+i,i*10));
            }

            return cutures;
        }
    }
}
