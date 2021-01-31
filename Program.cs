using System;

namespace NYP.Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun(1111);
            //-------------------------
            Gida gida = new Gida();
            Giyim giyim = new Giyim();
            //--------------------------
            Biskuvi biskuvi = new Biskuvi();
            Gomlek gomlek = new Gomlek();

            biskuvi.Markasi = "Ülker İkram";
            biskuvi.Barkod = 111;
            biskuvi.BarkodYazdir();

            gomlek.BarkodYazdir();
        }
    }
}
