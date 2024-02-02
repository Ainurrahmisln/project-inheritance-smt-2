using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person

    { 

        public string Name { get; set; }
        public string Alamat { get; set; }
        public int Tanggal { get; set; }
        public string Pesanan { get; set; }

        public void GetNameAndPesanan()
        {
            Console.WriteLine("The person has name: {0} and pesanan; {1}", Name, Pesanan);
        }
    }
}
