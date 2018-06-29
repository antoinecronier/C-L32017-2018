using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    /// <summary>
    /// Rutabaga.
    /// </summary>
    public class Rutabaga : Legume
    {
        private DateTime consumption;

        /// <summary>
        /// Consumption.
        /// </summary>
        public DateTime Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="taille">Taille.</param>
        public Rutabaga(string name, int taille) : base(name, taille)
        {
        }

        public Rutabaga()
        {

        }
    }
}
