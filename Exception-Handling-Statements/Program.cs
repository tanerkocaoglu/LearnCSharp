internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata Kontrol Mekanizmaları

        #region Çalışma Zamanı(Run-time) Hata Durumlarına Örnek
        // Çalışma zamanı hataları, programın çalışma anında karşılaştığı hatalardır.

        //Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
        //int sayi1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
        //int sayi2 = int.Parse(Console.ReadLine());

        //Console.WriteLine($"Toplam: {sayi1 + sayi2}");

        #endregion

        #region try catch
        //Uygulama sürecinde yaşanan olası hatayı kullanıcıya hissettirmeden, uygulamanın devam etmesini sağlar.Hataları loglama işlemleri için kullanılır.

        //Amaç
        //1. Hata oluştuğunda programın çökmemesini sağlamak.
        //2. Hata oluştuğunda kullanıcıya hata mesajı göstermek.
        //3. İşletim sistemleri aykırı durumlarda programı kapatır. try catch blokları kullanılarak manipülasyon ile bu durumun önüne geçilebilir.

        #region Örnek Kullanım
        //try
        //{
        //    Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
        //    int sayi1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
        //    int sayi2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        //}
        //catch 
        //{
        //    Console.WriteLine("Lütfen doğru bir ifade giriniz.");

        //}
        #endregion

        #region Doğru Kullanım

        //Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
        //int sayi1 = 0, sayi2 = 0;
        //try
        //{
        //    sayi1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
        //    sayi2 = int.Parse(Console.ReadLine());

        //}
        //catch
        //{
        //    Console.WriteLine("Lütfen doğru bir ifade giriniz.");

        //}
        //Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        #endregion

        #region Hata Parametreleri
        //Çalışma zamanında alınan hataya dair bilgi almak için kullanılan parametrelerdir.
        //Alınan hatanın türüne göre farklı hata mesajları gösterilir.

        //try
        //{
        //    int a = 0, b = 10;
        //    int sonuc = b / a;
        //}
        //catch (Exception hata) //Fırlatılan hata ile ilgili tüm bilgileri getirecek olan üst türdür.
        //{
        //    Console.WriteLine($"Hata : {hata}");
        //}

        #endregion

        #region Expection Dışında Farklı Bir Tür İle Hata Yakalama

        //try
        //{
        //    int s1 = 0, s2 = 10;
        //    int sonuc = s2 / s1;
        //}
        //catch bloğu, bir parametre tanımlanmazsa tüm hataları yakalar. Eğer tanımlarsa ve bu tür exception ise yine karşılar.
        //Fakat özelleştirilmiş bir hataya indirgenmişse sadece ilgili türle alakı hatalar ile ilgilenecektir.

        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Hata: " + ex.Message);
        //}

        #endregion

        #region Birden Fazla Catch Bloğu

        //try
        //{
        //    //DivideByZeroException
        //    int s1 = 0, s2 = 10;
        //    int sonuc = s2 / s1;

        //    //FormatException
        //    int.Parse("asdasd");
        //}
        //catch (DivideByZeroException dividezero)
        //{
        //    Console.WriteLine("Hata: " + dividezero.Message);
        //}
        //catch (FormatException format)
        //{
        //    Console.WriteLine("Hata: " + format.Message);
        //}
        ////catch bloklarının en sonuna Exception türünde bir parametre eklenirse tanımlanırsa alınan hata üstte tanımlanan türlerden biri değilse kesinlikle bu exception tetiklenir.
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Hata: " + ex.Message);
        //}

        #endregion

        #region finally
        //Hata alınsa da alınmasa da çalışacak olan bloktur.
        //try
        //{
        //    //hata verebilecek kodlar
        //    Console.WriteLine("try");
        //}
        //catch (Exception)
        //{
        //    //hata yakalandığında çalışacak kodlar
        //    Console.WriteLine("catch");
        //}
        //finally
        //{
        //    //hata alınsa da alınmasa da çalışacak kodlar
        //    Console.WriteLine("finally");
        //}

        #endregion

        #region when Yapısı İle Hata Filtreleme
        //try catch bloklarına when keywordu ile şart ekleyerek hata filtreleme yapılabiliriz.

        //string x = "a";
        //try
        //{
        //    int s1 = 0, s2 = 10;
        //    int sonuc = s2 / s1;
        //}
        //catch (DivideByZeroException ex) when (x == "a")
        //{
        //    Console.WriteLine("Hata: " + ex);
        //}

        #endregion


        #endregion


        #endregion
    }
}