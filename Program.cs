using System;

namespace sayiTahminUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
           // Sayı Tahmin Uygulaması
           // 1 - 100 arasında rastgele tutulan bir sayının buldurmaya çalışın .
           // Puanlama yapınız.
           // Kullanıcı devam etmek istiyorsa devam etsin.
           
                
            do
            {
                int tutulan = (new Random()).Next(1,10); //Next bie sayı üretmiş olacak
                int hak = 5;
                int sayi;
                int tur = 0;

                double soruPuanı = 100/hak;

                while (hak>0)
                {   tur++;
                    System.Console.Write($"{tur}. Sayı: ");
                    sayi = int.Parse(Console.ReadLine());
                    hak--;
                    if (sayi == tutulan)
                    {
                        double toplamPuan = 100 - (soruPuanı * (tur-1));
                        System.Console.WriteLine($"Tebrikler {tur} Defada Bildiniz");
                        System.Console.WriteLine($"Toplam Puan: {toplamPuan}");
                        break;
                    }else{
                        if (hak == 0)
                        {
                            break;
                        }

                        if (tutulan>sayi)
                        {
                            System.Console.WriteLine("Yukarı");
                        }else{
                            System.Console.WriteLine("Aşağı");
                        }
                    }
                
                }
                System.Console.WriteLine("Oyun Bitti");
                System.Console.WriteLine("Devam etmek istiyor musun ? (e/h): ");
                string result = Console.ReadLine();

                if (result=="h" || result=="hayır")
                {
                    break;
                }
            }
            while (true);
        }
    }
}
