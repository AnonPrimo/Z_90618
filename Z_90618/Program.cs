using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_90618
{

    struct Train
    {
        string city;
        int num;
        int hh;
        int mm;

        public void FillIn(string t, int n, int h, int m)
        {
            city = t;
            num = n;
            hh = h;
            mm = m;
        }

        public void Show()
        {
            Console.WriteLine("---------- Train -----------");
            Console.WriteLine("Destination \t|" + city);
            Console.WriteLine("Number of tain \t|" + num);
            Console.WriteLine("Departure time \t|" + hh + ":" + mm);
            Console.WriteLine();
        }

        public bool F(int n)
        {
            if (n == num) return true;
            else return false;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Train[] t = new Train[3];
            string c;
            int n, h, m;
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("-----------------");
                Console.Write("Input destination: ");
                c = Console.ReadLine();
                Console.Write("Input number of tain: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Input departure time: (hours): ");
                h = int.Parse(Console.ReadLine());
                Console.Write("  (minutes): ");
                m = int.Parse(Console.ReadLine());
                t[i].FillIn(c, n, h, m);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("--------- Find train ----------");
            Console.Write("Input num of train: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i=0; i<3; ++i)
            {
                if (t[i].F(n)) t[i].Show();
            }

            Console.ReadLine();
        }

    }
}
