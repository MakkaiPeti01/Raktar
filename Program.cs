using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            //Termek t = new Termek("P0", "Polo XXL", 1500, 10);
            //Console.WriteLine($"{t.KOD} - {t.NEV} - {t.AR} - {t.DB}");
            BeolvasRaktar();
            Console.ReadKey();
        }
    }
}
