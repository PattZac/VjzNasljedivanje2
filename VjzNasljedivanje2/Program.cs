using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjzNasljedivanje2
{
    class ProgramskiJezik
    {
        double postotak;
        public double Postotak { get => postotak; set => postotak = value; }
    }
    class Proceduralni : ProgramskiJezik { }
    class Objektni : ProgramskiJezik { }
    class Funkcionalni : ProgramskiJezik { }
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();
            double Zbroj = -1;
            do
            {
                Console.WriteLine("Unesi Posotak za Proceduralni: ");
                x.Postotak = Convert.ToInt32(Console.ReadLine());
                Zbroj = x.Postotak;
                if (Zbroj > 100 || Zbroj < 0)
                {
                    Console.WriteLine("- Nepravilno ispis!!!");
                    x.Postotak = -1;
                }

            } while (x.Postotak == -1);
            do
            {
                Console.WriteLine("\r\nUnesi Posotak za Objektni: ");
                y.Postotak = Convert.ToInt32(Console.ReadLine());
                Zbroj += y.Postotak;
                if (Zbroj > 100 || Zbroj < 0)
                {
                    Console.WriteLine("- Nepravilno ispis!!!");
                    Zbroj -= y.Postotak;
                    y.Postotak = -1;
                }
            } while (y.Postotak == -1);
            z.Postotak = 100-Zbroj;

            Zbroj += z.Postotak;

            if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
            {
                Console.WriteLine("\r\nNajzastupljenija Programskih Jezik je Proceduralni");
            }
            else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
            {
                Console.WriteLine("\r\nNajzastupljenija Programskih Jezik je Objektni");
            }
            else if (z.Postotak > y.Postotak && z.Postotak > x.Postotak)
            {
                Console.WriteLine("\r\nNajzastupljenija Programskih Jezik je Funkcionalni");
            }
            Console.ReadKey();
        }
    }
}
