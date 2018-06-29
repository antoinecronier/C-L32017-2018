using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    /// <summary>
    /// Navet.
    /// </summary>
    public class Navet : Legume, Recoltable
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Navet(string name, int taille) : base(name,taille)
        {

        }

        Legume Recoltable.Recolter()
        {
            return this;
        }
    }
}
