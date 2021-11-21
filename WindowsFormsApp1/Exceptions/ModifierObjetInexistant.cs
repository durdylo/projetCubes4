using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Exceptions
{
    internal class ModifierObjetInexistant : Exception
    {
        public ModifierObjetInexistant(string message) : base(message)
        {
        }
    }
}
