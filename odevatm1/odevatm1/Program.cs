using System;

namespace odevatm1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sifre = "9898";
            int bakiye, cekilecektutar, yatırılacaktutar;
            bakiye = 10000;
            Console.WriteLine("hoşgeldiniz");
            do
            {
                Console.WriteLine("şifrenizi giriniz");
                sifre = Console.ReadLine();

            } while (sifre != "9898");


            Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1-Bakiye görüntüleme");
            Console.WriteLine("2-para çekme");
            Console.WriteLine("3-para yatırma");
            Console.WriteLine("0-çıkış");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz" + bakiye);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("lütfen çekmek istediğiniz tutarı giriniz");
                    cekilecektutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecektutar > bakiye)
                    {
                        Console.WriteLine("bakiyenizden fazla para çekemezsiniz!");
                    }
                    else if (cekilecektutar % 5 != 0)
                    {
                        Console.WriteLine("sadece 5tl ve katlarını çekebilirsiniz.Lütfen yeniden deneyiniz.");
                    }
                    else
                    {
                        Console.WriteLine("mevcut bakiyeniz:" + (bakiye - cekilecektutar));
                    }
                    break;
                case "3":
                    Console.WriteLine("yatırmak istediğiniz tutarı giriniz:");
                    yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
                    if (yatırılacaktutar % 5 != 0)
                    {
                        Console.WriteLine("sadece kağıt para yerleştiriniz");
                    }
                    else
                    {
                        Console.WriteLine("mevcut bakiyeniz:" + (yatırılacaktutar + bakiye));
                    }
                    break;
                case "0":
                    Console.WriteLine("çıkış yapılıyor...");
                    Console.WriteLine("iyi günler.");
                    break;
                default:
                    Console.WriteLine("lütfen geçerli bir işlem giriniz!");
                    break;
            }
        }
    }
}
