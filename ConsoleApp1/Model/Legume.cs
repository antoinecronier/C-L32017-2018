using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    /// <summary>
    /// Legume.
    /// </summary>
    public abstract class Legume
    {
        private string name;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Taille.
        /// </summary>
        public int Taille { get; set; }

        /// <summary>
        /// Advance constructor
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="taille">Taille.</param>
        public Legume(string name, int taille)
        {
            Name = name;
            Taille = taille;
        }

        public Legume()
        {

        }

        /// <summary>
        /// Grow up my turnip.
        /// </summary>
        public void Grandir()
        {
            this.Taille += 3;
        }

        /// <summary>
        /// Cut the turnip if possible
        /// </summary>
        /// <param name="taille">Tall to cut</param>
        /// <returns></returns>
        public Legume Couper(int taille)
        {
            if (Taille - taille >= 0)
            {
                Taille -= taille;
            }

            return this;
        }
    }
}
