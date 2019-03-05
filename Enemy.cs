using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Enemy:Entity
    {
        internal override void Muerte()
        {
            Console.WriteLine("The enemy has been SLAINED");
        }
    }
}
