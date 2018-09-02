using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        public string Marka { get; set; }
        public int SerialNum { get; set; }
        public string DatCreate { get; set; }
        public string DatSell { get; set; }

        public PC()
        {
            Marka = "Philips";
            SerialNum = 1236;
            DatCreate = "3.05.2013";
            DatSell = "8.12.2014";
        }

        public PC(string m, int sn, string dc, string ds)
        {
            Marka = m;
            SerialNum = sn;
            DatCreate = dc;
            DatSell = ds;
        }

        public void Off()
        {
            Console.WriteLine("Computer excluded");
        }

        public void On()
        {
            Console.WriteLine("Computer included");
        }

        public void Restart()
        {
            Console.WriteLine("Computer's restart");
        }

        public void show()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Maka: " + Marka);
            Console.WriteLine("Serial number: " + SerialNum);
            Console.WriteLine("Date of created: " + DatCreate);
            Console.WriteLine("Date of sell: " + DatSell);
            Console.WriteLine();
        }

    }
}
