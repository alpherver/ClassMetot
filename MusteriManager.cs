using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        private List<Musteri> musteriListesi = new List<Musteri>();

        public void musteriEkle(Musteri musteri)
        {
            musteriListesi.Add(musteri);
        }
        public List<Musteri> MusteriListele()
        {
            return musteriListesi;
        }

        public void MusteriSil(int musteriId)
        {
            foreach ( Musteri musteri in musteriListesi ) 
            {
                if (musteri.musteriId == musteriId)
                {
                    musteriListesi.Remove(musteri);
                    break;
                }

            }       
        }
    }
}
