﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_AbstractFactoryMethod
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
