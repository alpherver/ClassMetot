using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetotDemo
{
    class ClassMetotDemo
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Alper";
            musteri1.musteriSoyad = "Tugrul";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri1);

            int musteriId = musteri1.musteriId;
            string musteriAdi = musteri1.musteriAdi;
            string musteriSoyad = musteri1.musteriSoyad;


            foreach (Musteri musteri in musteriManager.MusteriListele())
            {
            
                Console.WriteLine("Id: {0}, Ad: {1}, Soyad: {2}", musteriId, musteriAdi , musteriSoyad);
            }

            // Musteri silme
            musteriManager.MusteriSil(musteriId);

            // Musteri listeleme
            foreach (Musteri musteri in musteriManager.MusteriListele())
            {
                Console.WriteLine("Id: {0}, Ad: {1}, Soyad: {2}", musteriId, musteriAdi, musteriSoyad);
            }

            Console.ReadKey();

        }
    }
}