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

        #region while Döngüsü
        //while döngüsünde for gibi çalışabilmek için kombinasyonu kendimiz oluşturmalıyız.

        #region while iskelet
        //int i = 0;
        //while (i < 10)
        //{
        //    Console.WriteLine("-");
        //    i++;
        //}
        #endregion

        #region İnceleme 1
        //while döngüsü ile ekrana 10 defa Taner yazdıran program.
        //int i = 0;
        //while (i < 10)
        //{
        //    Console.WriteLine("Taner");
        //    i++;
        //}
        #endregion
        #region İnceleme 2
        //Klavyeden girilen sayıdan geriye doğru 0'a kadar olan sayıları ekrana yazdıran program.

        //int sayi = int.Parse(Console.ReadLine());
        //Console.Clear();
        //while (sayi > 0)
        //{

        //    Console.WriteLine(sayi);
        //    sayi--;
        //}

        #endregion
        #region İnceleme 3
        //0 ile 100 arasındaki tek sayıları toplayarak ekrana yazdıran program.

        //int sayi = 0, toplam = 0;
        //while (sayi < 100)
        //{
        //    if (sayi % 2 == 1)
        //    {
        //        toplam += sayi;
        //    }
        //    sayi++;
        //}
        //Console.WriteLine(toplam);

        #endregion
        #region İnceleme 4
        //Klavyeden girilen sayının faktöriyelini hesaplayan program.

        //int faktoriyel = 1;
        //int sayi = int.Parse(Console.ReadLine());
        //while (sayi > 0)
        //{
        //    faktoriyel *= sayi;
        //    sayi--;
        //}
        //Console.WriteLine(faktoriyel);
        #endregion
        #region İnceleme 5
        //O anki tarihin saniye değeri 5'in katı ise eğer tarihi ekranda gösteren uygulamayı yazınız.

        //while (true)
        //{
        //    if (DateTime.Now.Second % 5 == 0) { Console.WriteLine(DateTime.Now); }
        //}

        #endregion

        #endregion

        #region do-while Döngüsü
        //do while şart sağlanmasa bile döngüyü birkez çalıştırır.

        //while (false)
        //{
        //    Console.WriteLine("Taner");
        //}
        //do
        //{
        //    Console.WriteLine("Taner");
        //} while (false);

        #endregion

        #region Sonsuz Döngüler

        #region for
        //bool dongu = true;
        //for (; dongu;)
        //{
        //    if (true)
        //    {
        //        dongu = !dongu;
        //    }
        //}

        #endregion
        #region while
        //bool durum = false;
        //while (!durum)
        //{
        //    if (true)
        //    {
        //        durum = !durum;
        //    }
        //}

        #endregion
        #region do while
        //bool durum = true;
        //do
        //{
        //    if (true)
        //    {
        //        durum = !durum;
        //    }

        //} while (durum);
        #endregion


        #endregion

        #region İç içe Döngüler

        #region for

        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        for (int k = 0; k < 3; k++)
        //        {
        //            int p = 0;
        //            while (p < 4)
        //            {
        //                p++;
        //            }
        //        }
        //    }
        //}

        #endregion

        #endregion


    }
}