internal class Program
{
    private static void Main(string[] args)
    {
        #region Yardımcı Manevratik Komutlar
        //Kodu durdurmak, devamını okumamak, var olan bir döngüden çıkış yapmak yani kodu yönlendirmek için kullanılan komutlardır.
        //Manevratik komutlar kodun yönlendirmelerini daha efektif yapmamızı sağlarlar.

        #region break
        //sadece switch case ve döngülerde kullanılır.

        //while (true)
        //{
        //    if (DateTime.Now.Second == 25)
        //        break;
        //    Console.WriteLine(DateTime.Now);
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (j == 1)
        //            break;
        //        Console.WriteLine("i: " + i + " j: " + j);
        //    }
        //}

        #endregion

        #region break Örnek         
        //Kullanıcıdan "t" harfini girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran programı yazınız.

        //int toplam = 0;
        //while (true)
        //{
        //    Console.WriteLine("Lütfen bir sayı giriniz: ");
        //    string girilenDeger = Console.ReadLine();
        //    if (girilenDeger == "t")
        //    {
        //        Console.WriteLine(toplam);
        //        break;
        //    }
        //    else
        //    {
        //        toplam += int.Parse(girilenDeger);
        //    }
        //}

        #endregion

        #region break Örnek 2
        //Kullanıcıdan alınan sonsuz adet sayı değerinden 37'nin katı girildiğinde sonlanan programı yazınız.

        //while (true)
        //{
        //    Console.WriteLine("Bir sayı giriniz: ");
        //    int sayi = int.Parse(Console.ReadLine());
        //    if (sayi % 37 == 0)
        //    {
        //        Console.WriteLine("37'nin katı girdiniz.");
        //        break;
        //    }
        //}

        #endregion

        



        #endregion

    }
}