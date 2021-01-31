using System;
namespace NYP.Kalitim
{
    internal class Urun
    {
        public string Markasi { get; set; }
        public int AlisFiyati { get; set; }
        public int SatisFiyati { get; set;}
            public int Barkod { get; set; }
         public void BarkodYazdir()
         {
           Console.WriteLine($" {Markasi} markalı ürünün borkodu = {Barkod} ") ;

         }
            public Urun(int Barkod)
            {
                this.Barkod = Barkod;
            }
    }
}