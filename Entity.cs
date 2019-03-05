using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    abstract class Entity
    {
        private int health;
        private int mana;

        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100)
                {
                    health = 100;
                }
                else if (value < 100)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }
        public int Mana
        {
            get { return mana; }
            set
            {
                if (value > 100)
                {
                    mana = 100;
                }
                else if (value < 100)
                {
                    mana = 0;
                }
                else
                {
                    mana = value;
                }
            }
        }

        internal abstract void Muerte();
        internal void Muerte1()
        {
            Console.WriteLine("Death . . .");
        }
    }
}


