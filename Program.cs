using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    

    
    class Program
    {

        static void Main(string[] args)
        {
            int b, c, f=0;
            Entity slayer = new Slayer();
            Entity enemy = new Enemy();
            Random rdn = new Random();

            slayer.Health = 100;
            enemy.Health = 100;
            c = enemy.Health;
            b = slayer.Health;
            do
            {
                int a = rdn.Next(1, 10);
                b=b-a;
                Console.WriteLine(b);
                int d = rdn.Next(1, 10);
                c=c-d;
                Console.WriteLine(c);
                if(b<=0)
                {
                    f=f+1;
                }
                else if(c<=0)
                {
                    f++;
                }
                else
                {
                    Console.WriteLine("Mash Again");
                }
                Console.ReadKey();
                
            }
            while (f<=0);

            if(b<=0)
            {
                Console.WriteLine(b);
                slayer.Muerte();
            }
            else
            {
                Console.WriteLine(c);
                enemy.Muerte();
            }
            Console.ReadKey();
        }
    }
}
