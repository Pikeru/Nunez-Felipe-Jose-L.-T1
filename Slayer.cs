using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Slayer: Entity
    {
        internal override void Muerte()
        {
            Console.WriteLine("You have been Slained");
        }
    }
}
