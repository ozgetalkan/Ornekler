using System;
using System.Collections;
enum GunEnum
{
    pazartesi,
    sali,
    carsamba,
    persembe,
    cuma,
    cumartesi,
    pazar
}

namespace Ornek1._1
{
    internal class Program
    {
        class Kisi
        {
            public Kisi(string ad, string soyad)
            {
                Ad = ad;
                Soyad = soyad;
            }
            public String Ad { get; set; } 
            public String Soyad { get; set; }   
        }
        static void Main(string[] args)
        {
            //Samp1(GunEnum.sali);
        }
        static void Samp1(GunEnum secilenGun)
        {
            switch (secilenGun)
            {
                case GunEnum.pazartesi:
                    Console.WriteLine("Pazartesi");
                    break;
                case GunEnum.sali:
                    Console.WriteLine("Salı");
                    break;
                case GunEnum.carsamba:
                    Console.WriteLine("Çarşamba");
                    break;
                case GunEnum.persembe:
                    Console.WriteLine("Perşembe");
                    break;
                case GunEnum.cuma:
                    Console.WriteLine("Cuma");
                    break;
                default:
                    Console.WriteLine("Haftasonu");
                    break;
            }
        }

        static void Samp2()
        {
            Kisi k1 = new Kisi("Veli", "Demir");
            Kisi k2 = new Kisi("Ebru", "Zorba");

            ArrayList list = new ArrayList();  
            list.Add(k1);
            list.Add(k2);

            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(k1);
            kisiler.Add(k2);

            IEnumerator ie = kisiler.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current.ToString());
            }
            do
            {

            }
            while (true);
        }
    }
}