using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen1 = new Ogretmen();
            Ogrenci ogrenci1 = new Ogrenci();

            ogretmen1.ad = "Ahmet";
            ogretmen1.soyad = "Colt";
            ogretmen1.adres = "kadıköy";
            ogretmen1.maas = 3500F;
            ogretmen1.brans = "fizik";
            ogretmen1.tcno = "1234123412";
            ogretmen1.vergiNo = "11234123";
            ogretmen1.dogumtarihi = Convert.ToDateTime("1970.10.19");
            Console.WriteLine(ogretmen1.dogumtarihi);

            ogrenci1.ad = "mustafa";
            ogrenci1.soyad = "topaloğlu";
            Console.WriteLine(ogrenci1.ad);

            Fizikogretmeni Fizikci1 = new Fizikogretmeni();
            // insan özelliğini aldı
            Fizikci1.ad = "hale";
            Fizikci1.soyad = "ataman";
            // öğretmen özelliğini aldı
            Fizikci1.vergiNo = "123412";
            Fizikci1.maas = 3124F;
            // Fizik öğretmeni sınıfından özellik aldı
            Fizikci1.ZumreNumarası = 8;



            Console.Read();
        }
    }
    class insan
    {
        public string ad;
        public string soyad;
        public DateTime dogumtarihi;
        public string tcno;
        public string adres;
    }
    class Ogrenci : insan
    {
        public string okulnumara;
        public Ogretmen sinifogretmeni;
        public float NotOrtalaması;
    }
    class Ogretmen : insan
    {
        public float maas;
        public string brans;
        public string vergiNo;
    }
    class Fizikogretmeni : Ogretmen
    {
        public short ZumreNumarası;
    }
}