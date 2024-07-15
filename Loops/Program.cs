internal class Program
{
    private static void Main(string[] args)
    {

        #region for Döngüsü
        //Ardışık operasyonlar kullanılan algoritmalarda for döngüsü kullanılır.

        #region Kritik 1
        //Ekrena 10 kez Hilmi yazdıran program
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i + ". Hilmi");
        //}
        #endregion
        #region Kritik 2
        //Ekrana 10 kere Hilmi yazdıran program.
        //for (int i = 10; i > 0; i--)
        //{
        //    Console.WriteLine("Hilmi");
        //}
        #endregion

        #region Örnek 1
        //Ekrana 1-10 arasındaki sayıları yazdıran program.
        #region 1.Çözüm
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion
        #region 2.Çözüm -- Saçma
        //for (int i = 50; i < 60; i++)
        //{
        //    Console.WriteLine(i - 49);
        //}
        #endregion
        #endregion
        #region Örnek 2
        //1'den 40'a kadar olan çift sayıların toplamını veren program.

        //int toplam = 0;
        //for (int i = 1; i < 40; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        toplam += i;
        //    }
        //}
        //Console.WriteLine(toplam);
        #endregion
        #region Örnek 3
        //Klavyeden girilen sayının faktöriyelini alan program

        #region 1.Çözüm (3 değişkenli)
        //int sayi, faktoriyel = 1;
        //Console.WriteLine("Faktöriyeli alınacak sayıyı giriniz: ");
        //sayi = int.Parse(Console.ReadLine());
        //if (sayi == 0 || sayi == 1)
        //{
        //    Console.WriteLine($"Sayınızın Faktöriyeli: {faktoriyel}");
        //}
        //else
        //{
        //    for (int i = 1; i <= sayi; i++)
        //    {

        //        faktoriyel *= i;
        //    }
        //    Console.WriteLine($"Sayınızın Faktöriyeli: {faktoriyel}");
        //}
        //Console.ReadKey();
        #endregion
        #region 2.Çözüm (2 değişkenli)

        //int sayi, faktoriyel = 1;
        //Console.WriteLine("Faktöriyeli alınacak sayıyı giriniz: ");
        //sayi = int.Parse(Console.ReadLine());
        //if (sayi == 0)
        //{
        //    Console.WriteLine($"Sayınızın faktöriyeli: {faktoriyel}");
        //}
        //else
        //{
        //    for (; sayi > 1; sayi--)
        //    {
        //        faktoriyel *= sayi;
        //    }
        //    Console.WriteLine($"Sayınızın faktöriyeli: {faktoriyel}");
        //}

        #endregion
        #region 3.Çözüm
        //Console.Write("Bir Sayı Giriniz: ");
        //int sayi = int.Parse(Console.ReadLine());
        //double faksayi = 1;
        //for (; !(sayi == 0); sayi--)
        //{
        //    faksayi *= sayi;
        //}
        //Console.WriteLine(faksayi);
        #endregion
        #endregion

        #region Varyasyon 1
        //for (int i = 0; i < 10; i++)
        //{

        //}
        #endregion
        #region Vasyasyon 2
        //int i = 0;
        //for (; i < 10; i++)
        //{

        //}
        #endregion
        #region Vasyasyon 3
        //int i = 0;
        //for (; i < 10;)
        //{
        //    i++;
        //}
        #endregion
        #region Varyasyon 4
        //for (; ; )
        //{

        //}
        #endregion
        #region Varyasyon 5
        //for (int i = 0, i2 = 0; i < 10 && i2 < 5; i++, i2++)
        //{

        //}
        #endregion
        #endregion


    }
}