using System;
using System.Threading;

namespace WindowsFormsApp1
{
    class Sunucular
    {
        public int kapasite { get; set; }

        public int istek_alma_suresi { get; set; }

        public int  istek_donus_suresi { get; set; }

        public int istekAlmaKapatisesi { get; set; }

        public int istekVermeKapatisesi { get; set; }

        public int istek_sayisi { get; set; }

        public Sunucular olusturucu { get; set; }


        public Sunucular()
        {

        }

        public Sunucular(int kapasite, int istek_alma_suresi, int istek_donus_suresi, int istekAlmaKapatisesi, int istekVermeKapatisesi, int istek_sayisi)
        {
            this.kapasite = kapasite;
            this.istek_alma_suresi = istek_alma_suresi;
            this.istek_donus_suresi = istek_donus_suresi;
            this.istekAlmaKapatisesi = istekAlmaKapatisesi;
            this.istekVermeKapatisesi = istekVermeKapatisesi;
            this.istek_sayisi = istek_sayisi;
        }

        public Sunucular AltSunucOlustur()
        {
            Sunucular altSunucu = new Sunucular(5000, 500, 300, 50, 50, this.istek_sayisi/2);

            altSunucu.olusturucu = this;

            this.istek_sayisi -= this.istek_sayisi / 2;

            return altSunucu;
        }

        public int IstekOlusturma(Sunucular sunucu)
        {
            int istek;
            Random random = new Random();
            istek = random.Next(1, sunucu.istekAlmaKapatisesi+1);

            return istek;
        }


        public void SIstekGonderme()
        {
            Thread.Sleep(this.istek_alma_suresi);
            Random random = new Random();
            if(this.istek_sayisi <= this.kapasite)
                this.istek_sayisi += random.Next(1, this.istekAlmaKapatisesi + 1);
        }

        public void SIstekYoketme()
        {
            Thread.Sleep(this.istek_donus_suresi);
            Random random = new Random();
            if (this.istek_sayisi >= 0)
                this.istek_sayisi -= random.Next(1, this.istekVermeKapatisesi + 1);
        }

        public void SunucuSomur(Sunucular somurulen)
        {
            Thread.Sleep(this.istek_alma_suresi);
            Random random = new Random();
            int somuru = random.Next(1, this.istekAlmaKapatisesi + 1);
            somurulen.istek_sayisi -= somuru;
            this.istek_sayisi += somuru;
        }

        public Boolean SunucuKontrol()
        {
            bool karar = this.istek_sayisi *100 / this.kapasite >= 70;

            return karar;
        }

        





    }
}
