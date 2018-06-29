using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    /// <summary>
    /// Recoltable.
    /// </summary>
    public interface Recoltable
    {
        /// <summary>
        /// Recolter.
        /// </summary>
        /// <returns>Legume.</returns>
        Legume Recolter();
    }
}
