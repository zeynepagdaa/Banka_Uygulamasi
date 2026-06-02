using System;
using System.Collections.Generic;


namespace nyp_odev2
{
    
    public abstract class MusteriBilgileri
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int MusteriNo { get; set; }
        public List<HesapBilgileri> Hesaplar { get; set; }

        public string TamAdGosterim => $"{MusteriNo} - {Ad} {Soyad}";
        public MusteriBilgileri(string ad, string soyad, int musteriNo)
        {

            Ad = ad;
            Soyad = soyad;
            MusteriNo = musteriNo;
            Hesaplar = new List<HesapBilgileri>();
        }


        public abstract decimal HavaleUcretiHesapla(decimal havaleTutari);
    }



    public class BireyselMusteri : MusteriBilgileri
    {
        public BireyselMusteri(string ad, string soyad, int musteriNo) : base(ad, soyad, musteriNo) { }

        public override decimal HavaleUcretiHesapla(decimal havaleTutari)
        {
            return havaleTutari * 0.02m;
        }
    }

    public class TicariMusteri : MusteriBilgileri
    {
        public TicariMusteri(string ad, string soyad, int musteriNo) : base(ad, soyad, musteriNo) { }

        public override decimal HavaleUcretiHesapla(decimal havaleTutari)
        {
            return 0m;
        }
    }
    
    

}