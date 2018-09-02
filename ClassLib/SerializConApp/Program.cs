using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pc = new List<PC>();
            pc.Add(new PC());
            pc.Add(new PC("Asus", 564, "3.02.2010", "5.09.2011"));
            pc.Add(new PC("HP", 879, "3.02.2010", "5.09.2011"));

            BinaryFormatter binform = new BinaryFormatter();

            using (FileStream fs = new FileStream("listSerial.txt", FileMode.OpenOrCreate))
            {
                    binform.Serialize(fs, pc);
                Console.WriteLine("Serialized");
            }
            


            Console.ReadLine();
        }
    }
}
