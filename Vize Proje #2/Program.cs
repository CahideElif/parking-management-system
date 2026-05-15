using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Proje__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int otopark=19, saat,secim;
            string plaka;

            while (true)
            {
                Console.Write("\n1-Araç Girişi\n2-Araç Çıkışı\n(-1)Programdan Çıkış\nSeçiniz:");
                secim=int.Parse(Console.ReadLine());
                if (secim==1)
                {
                    Console.WriteLine("Araç girişi yapılacak.");
                    if (otopark < 20)
                    {
                        Console.WriteLine("Plakanızı giriniz: ");
                        plaka = Console.ReadLine();
                        otopark++;
                        Console.WriteLine(plaka + " plakalı araç girdi.Otoparktaki araç sayısı: " + otopark);
                    }
                    else if (otopark >= 20)
                    {
                        Console.WriteLine("Otopark dolu. Araç girişi yapılamaz. Araç çıkışı yapınız.");
                    } 
                }
                else if (secim==2)
                {
                    Console.WriteLine("Plakanızı giriniz: ");
                    plaka= Console.ReadLine();
                    otopark--;
                    Console.WriteLine("Otoparkta kaç saat kaldınız? Giriniz: ");
                    saat = int.Parse(Console.ReadLine());
                    if(saat==1)
                    {
                        Console.WriteLine("Ödenecek tutar 5 TL." + plaka + " plakalı araç çıktı. Otoparktaktaki araç sayısı: " + otopark);
                    }
                    else if (saat == 2)
                    {
                        Console.WriteLine("Ödenecek tutar 10 TL." + plaka + " plakalı araç çıktı. Otoparktaktaki araç sayısı: " + otopark);
                    }
                    else if(saat == 3)
                    {
                        Console.WriteLine("Ödenecek tutar 15 TL." + plaka + " plakalı araç çıktı. Otoparktaktaki araç sayısı: " + otopark);

                    }
                    else if (saat >= 4)
                    {
                        Console.WriteLine("ödenecek tutat 40 TL." + plaka + " plakalı araç çıktı. Otoparktaktaki araç sayısı: " + otopark);
                    }
                }
                else if (secim== -1)
                {
                    Console.WriteLine("Otopark programından çıkış yapılıyor.");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz değer girişi yapıldı. Programdan çıkış yapılıyor.");
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
