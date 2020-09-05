using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_AbstractFactoryMethod
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}
