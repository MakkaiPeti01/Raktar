using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Raktar
{
    class Program
    {
        static List<Termek> lista = new List<Termek>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                lista.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
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
