using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
namespace Deserialized
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BinaryFormatter binform = new BinaryFormatter();

            using (FileStream fs = new FileStream("Z:\\StudentsFiles\\RPZ\\RPZ3\\Чубіна\\Serialization_2_9_18\\ClassLib\\SerializConApp\\bin\\Debug\\listSerial.txt", FileMode.OpenOrCreate))
            {

                List<PC> pc =  (List<PC>)binform.Deserialize(fs);
                foreach(PC p in pc)
                    p.show();
            }
            
            Console.ReadLine();
        }
    }
}
