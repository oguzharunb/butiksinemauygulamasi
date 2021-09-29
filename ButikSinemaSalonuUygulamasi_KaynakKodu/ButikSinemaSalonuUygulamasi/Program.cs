using System;

namespace ButikSinemaSalonuUygulamasi
{
    class Program
    {
        



        static Sinema Snm;

        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            Baslangic();


            while (true)
            {
                Console.WriteLine();
                Menu();
                string secim = SecimAl();
                Console.WriteLine();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSatisi();
                        break;
                    case "2":
                    case "R":
                        BiletIade();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                }
            }

        }
        
        static void Baslangic()
        {


            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı: ");
            string filmAdi = Console.ReadLine();
            Console.Write("Kapasite: ");
            int kapasite = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı: ");
            float tamBiletF = float.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı: ");
            float yarimBiletF = float.Parse(Console.ReadLine());
            Snm = new Sinema(filmAdi, kapasite, tamBiletF, yarimBiletF);

            Console.WriteLine();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)    ");
            Console.WriteLine("2 - Bilet İade(R)   ");
            Console.WriteLine("3 - Durum Bilgisi(D)");
            Console.WriteLine("4 - Çıkış(X)        ");
            Console.WriteLine();
        }

        static string SecimAl()
        {
            Console.Write("Seçiminiz: ");
            return Console.ReadLine().ToUpper();
        }

        static void DurumBilgisi()
        {

            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Toplam Yarım Bilet Adedi: " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukAdediGetir());

        }
        static void BiletSatisi()
        {

            Console.WriteLine("Bilet Sat-----");

            Console.Write("Tam Bilet Adedi: ");
            bool x = int.TryParse(Console.ReadLine(), out int tamAdet);

            if (x == false)
            {
                Console.WriteLine("hatalı giriş yapıldı bilet satışı gerçekleşemedi");
                return;
            }

            Console.Write("Yarım Bilet Adedi: ");
            bool y = int.TryParse(Console.ReadLine(), out int yarimAdet);

            if (y == false)
            {
                Console.WriteLine("hatalı giriş yapıldı bilet satışı gerçekleşemedi");
                return;
            }

            Snm.BiletSat(tamAdet, yarimAdet);

        }
       
        
        static void BiletIade()
        {
            Console.WriteLine("bilet iade et -----");
            Console.Write("iade edilecek tam bilet adedi: ");
            int iadeTamAdet = int.Parse(Console.ReadLine());
            Console.Write("iade edilecek yarım bilet adedi: ");
            int iadeYarimAdet = int.Parse(Console.ReadLine());

            Snm.BiletIade(iadeTamAdet, iadeYarimAdet);

        }

    }
}
