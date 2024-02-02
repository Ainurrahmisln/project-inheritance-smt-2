using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Inheritance.Person();
            person.Name = "ai";
            person.Alamat = "jl.kaliurang";
            person.Tanggal = 02 - 12 - 2023;
            person.Pesanan = "buku";
            person.GetNameAndPesanan();

            Pembeli pembeli = new Pembeli();
            pembeli.Name = "ama";
            pembeli.Alamat = "jl.kebun cabe";
            pembeli.Tanggal = 02 - 11 - 2023;
            pembeli.Pesanan = "kopi";
            pembeli.GetNamaAndAlamat();

            Penjual penjual = new Penjual();
            penjual.NamaToko = "toko rahmizaki";
            penjual.Alamat = "jl.blangkejeren";
            penjual.Tanggal = 02 - 11 - 2024;
            penjual.Pesanan = "sabuk";
            penjual.GetNamaTokoAndAlamat();
        }
    }
}
