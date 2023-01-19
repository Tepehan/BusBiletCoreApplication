using System;

namespace BusBiletCoreApplication.PagedList
{
    public class Pager
    {

        public int baslangicSayfasi { get; set; }
        public int bitisSayfasi { get; set; }
        public int sayfaSayisi { get; set; }
        public int goruntulenenKayitSayisi { get; set; }
        public int toplamKayitSayisi { get; set; }
        public int aktifSayfasi { get; set; }
        public Pager()
        {

        }
        public Pager(int pageSize, int itemCounts, int page)
        {
           
            aktifSayfasi = page;
            goruntulenenKayitSayisi = pageSize;
            toplamKayitSayisi = itemCounts;

            sayfaSayisi = (int)Math.Ceiling((decimal)toplamKayitSayisi / (decimal)goruntulenenKayitSayisi);

            baslangicSayfasi = aktifSayfasi - 5;
            bitisSayfasi = aktifSayfasi + 4;

            if (baslangicSayfasi<1)
            {
                bitisSayfasi = bitisSayfasi - (baslangicSayfasi - 1);
                baslangicSayfasi = 1;
            }
            if (bitisSayfasi > sayfaSayisi)
            {
                bitisSayfasi = sayfaSayisi;
                if (bitisSayfasi>10)
                {
                    baslangicSayfasi = bitisSayfasi - 9;
                }
            }

          
        }
    }
}
