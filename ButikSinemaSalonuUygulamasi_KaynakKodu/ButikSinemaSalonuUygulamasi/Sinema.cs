using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaSalonuUygulamasi
{
    class Sinema
    {
        public string FilmAdi;
        public int Kapasite;
        public float TamBiletFiyati;
        public float YarimBiletFiyati;
        public int ToplamTamBiletAdedi;
        public int ToplamYarimBiletAdedi;
        public float Ciro;
        public int BosKoltukAdedi
        {
            get
            {
                return Kapasite - (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
            }
        }


        public Sinema(string filmadi, int kapasite, float tambiletf, float yarimbiletf)
        {
            FilmAdi = filmadi;
            Kapasite = kapasite;
            TamBiletFiyati = tambiletf;
            YarimBiletFiyati = yarimbiletf;

        }

        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {

            if (BosKoltukAdediGetir() < tamBiletAdedi + yarimBiletAdedi)
            {
                Console.WriteLine("yeterli boş koltuk yok");
                Console.WriteLine("boş koltuk sayısı: " + BosKoltukAdediGetir());
                return;
            }

            this.ToplamTamBiletAdedi += tamBiletAdedi;
            this.ToplamYarimBiletAdedi += yarimBiletAdedi;
            ciroHesapla();
            Console.WriteLine("işlem gerçekleştirildi. ");

        }

        public void BiletIade(int IadeTamAdet, int IadeYarimAdet)
        {

            if (ToplamTamBiletAdedi < IadeTamAdet)
            {
                Console.WriteLine(IadeTamAdet + " adet  tam bilet iade edilemez çünkü o kadar tam bilet yok");
                return;
            }

            else if (ToplamYarimBiletAdedi < IadeYarimAdet)
            {
                Console.WriteLine(IadeTamAdet + " adet yarım bilet iade edilemez çünkü o kadar yarım bilet yok");
                return;
            }


            this.ToplamTamBiletAdedi -= IadeTamAdet;
            this.ToplamYarimBiletAdedi -= IadeYarimAdet;
            ciroHesapla();
        }

        private void ciroHesapla()
        {
            this.Ciro = (ToplamTamBiletAdedi * TamBiletFiyati) + (ToplamYarimBiletAdedi * YarimBiletFiyati);

        }

        public int BosKoltukAdediGetir()
        {
            return this.Kapasite - (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
        }
    }


}
