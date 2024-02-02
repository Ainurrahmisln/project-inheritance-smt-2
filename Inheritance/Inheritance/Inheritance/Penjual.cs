using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Penjual


    {

        public string NamaToko { get; set; }
        public string Alamat { get; set; }
        public int Tanggal { get; set; }
        public string Pesanan { get; set; }

        public void GetNamaTokoAndAlamat()
        {
            Console.WriteLine("The person has nama: {0} and alamat; {1}", NamaToko, Alamat);
        }
    }
}
