internal class Program
{
    private static void Main(string[] args)
    {
        #region Sınırlılıklar
        //Dizilerde tanımalama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
        //Bir dizi tanımlaması yapıldığı an kullansakta kullanmasakta bellekte verilen eleman sayısı kadar yer ayrılır. Bu durumda bellek boyutunda ekstra maliyete sebep olacağı için bu bir sınırlılıktır.
        //Dizilerde elemanlara değer atarken indexer operatörüyle çok kullanılmaktadır. Bu bir sınırlılıktır.

        #endregion

        #region Diziler
        //Tek bir değişken altında birden fazla aynı türde değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
        //Diziler veri kümeleri oldukları için, içlerindeki birden fazla veri üzerinde kümesel işlemler yapmamızı sağlarlar.
        //Bir dizi sadece tek bir türde veri tutabilir. Yani bir dizi içerisinde sadece sayısal veriler, sadece metinsel veriler ya da sadece mantıksal veriler tutulabilir.
        //Diziler içerisine eleman eklendikçe sıralı bir şekilde eklenirler. Yani dizinin ilk elemanı 0. index'te, ikinci elemanı 1. index'te, üçüncü elemanı 2. index'te tutulur.
        //Dizilerde belirtilen eleman sayısı aşılamaz. Yani bir diziye 5 eleman tanımlanmışsa, 6. eleman eklenemez. Bu bir sınırlılıktır.


        #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme

        //string[] personel =
        //[
        //    "Ali",
        //    "Veli",
        //    "Ahmet",
        //    "Mehmet",
        //    "Ayşe",
        //    "Fatma",
        //    "Zeynep",
        //    "Kemal",
        //    "Hüseyin",
        //    "Merve",
        //];

        //for (int i = 0; i < personel.Length; i++)
        //{
        //    Console.WriteLine(personel[i]);
        //}


        #endregion

        #region Dizi Tanımlama Varyasyonları

        #region 1.Varyasyon
        //int[] yaslar = new int[5];
        #endregion
        #region 2.Varyasyon
        //int[] yaslar = { 30, 25, 42, 52 };
        //string[] isimler = { "Ali", "Veli", "Ahmet", "Mehmet" };
        #endregion
        #region 3.Varyasyon
        //string[] isimler = new string[] {"Taner","Ali","Mustafa","Nazlı"};
        #endregion
        #region 4.Varyasyon
        //string[] isimler = new string[3] { "a", "b", "c" };
        #endregion
        #region 5.Varyasyon
        //int[] sayilar = new[] { 1, 2, 3, 4, 5 };
        //var sayilar2 = new[] { 1, 2, 3, 4, 5 };
        #endregion
        #endregion

        #region Array Sınıfı
        //Dizi olarak tanımlanan değişkenler Array sınıfından türetilmişlerdir.
        //Dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur.

        //Array yaslar = new int[5];


        #region Array Türünden Dizilere Değer Atama

        #region 1.Yöntem
        //int[] dizi = new int[3];
        //dizi[0] = 14;
        //dizi[1] = 22;
        //dizi[2] = 36;
        //Array dizi2 = dizi;
        #endregion
        #region 2.Yöntem
        //Array dizi = new int[] { 2, 3, 5, 8, 5 };
        #endregion
        #region 3.Yöntem
        //Array dizi = new int[3];
        //dizi.SetValue(5, 8);
        #endregion
        #endregion


        //Array isimler = new[] { "Ahmet", "Mehmet", "Yavuz", "Muharrem", "Bülent" };

        #region Metotlar

        #region Clear
        //Dizi içerisindeki elemanları siliyor diye bilinir ancak bu yanlıştır. Dizi içerisindeki elemanlara, dizinin türüne uygun default değeri atayan bir fonksiyorundur.
        //Array.Clear(isimler, 0, isimler.Length);
        #endregion
        #region Copy
        //Elimizdeki bir dizininn verilenin bir başka diziye koplayamamızı sağlayan bir fonksiyondur.
        //string[] isimler2 = new string[isimler.Length];
        //Array.Copy(isimler, isimler2, 5);
        //Array.Copy(isimler, 2, isimler2, 0, 2);
        //for (int i = 0; i < isimler2.Length; i++)
        //{
        //    Console.WriteLine(isimler2[i]);
        //}
        #endregion
        #region IndexOf
        //Dizi içerisinde bir elemanın var olup olmadığını kontrol eder ve varsa o elemanın index numarasını döndürür. Eğer eleman dizide yoksa -1 döndürür.
        //int index = Array.IndexOf(isimler, "Mehmet");
        //if (index != -1)
        //{
        //    Console.WriteLine($"Aranan index numarası : {index}");
        //}
        //Array.IndexOf(isimler, "Muharrem", 0, 2);
        #endregion
        #region Reverse
        //Elimizdeki bir diziyi tersine çevirmemizi sağlayan bir fonksiyondur.
        //Array.Reverse(isimler);
        //foreach (var item in isimler)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion
        #region Sort
        //Elimizdeki dizinin elemanlarını küçükten büyüğe sıralamamızı sağlayan bir fonksiyondur.
        //Array.Sort(isimler);
        //for (int i = 0; i < isimler.Length; i++)
        //{
        //    Console.WriteLine(isimler.GetValue(i));
        //}
        #endregion

        #endregion
        #region Özellikler

        #region IsReadOnly
        //Console.WriteLine(isimler.IsReadOnly);
        #endregion
        #region IsFixedSize
        //Bir veri kümesinin eleman sayısının sabit olup olmadığını belirten bir özelliktir.
        //Tüm dizilerde eleman sayısı sabit olduğu için bu özellik sürekli true döner. ArrayList koleksiyonu false döner.

        //Console.WriteLine(isimler.IsFixedSize);
        #endregion
        #region Rank
        //İlgili dizinin derecesini döndürür. Yani kaç boyutlu olduğunu döndürür.

        //int[,,] x = new int[3, 2, 3];
        #endregion
        #endregion

        #region CreateInstance
        //Normalde aşağıdaki gibi yapılan dizi tanımlaması Array sınıfının CreateInstane metodunu kullanmaktadır.

        int[] yas = new int[3];
        Array yas2 = Array.CreateInstance(typeof(int), 3);
        #endregion

        #endregion


        #endregion

        #region Ranges and Indices
        //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        #region System.Index
        //Index index = 5; --> Soldan 0 - (n-1)
        //Index index = ^3; --> Sağdan n - 1
        //Console.WriteLine(sayilar[index]);
        #endregion
        #region System.Range
        //Range range = 2..5;
        //var sayilar2 = sayilar[range];

        //Range range = ..; --> Tüm diziye karşılık gelir.
        //var sayilar2 = sayilar[range];
        #endregion
        #region ^ Operatörü
        //Console.WriteLine(sayilar[^1]); --> Dizinin son elemanını döndürür.
        //Index i = ^3;

        #endregion





        #endregion

        #region Çok Boyutlu Diziler
        //Çok boyutlu diziler oyun programlama, grafik programlama, matris işlemleri gibi alanlarda sıkça kullanılan veri yapılarıdır.
        //2 boyutlu diziler x ve y olmak üzere 2 boyutlu bir düzlemde verileri tutar

        #region Çok Boyutlu Dizi Tanımlaması
        #region 2 Boyutlu Dizi Tanımlaması
        //int[,] sayilar = new int[3, 4];
        #endregion
        #region 2 Boyutludan Fazla Dizi Tanımlaması
        //2 dereceden fazla olan dizileri gerçek hayatta pek kullanmayız. Çünkü karmaşık bir yapıya sahiptirler. Bu yüzden genellikle 2 boyutlu diziler kullanılır.

        //int[,,,] sayilar = new int[3, 4, 5, 6];
        #endregion
        #endregion

        #region Tanınlanmış Çok Boyutlu Diziye Değer Atama
        #region 2 Dereceli Dizi Örneklendirme
        //int[,] sayilar = new int[3, 4];
        //sayilar[1, 2] = 5;
        //sayilar[2, 0] = 10;
        #endregion
        #region Çok Dereceli Dizi Örneklendirme

        #region Örnek 1
        //int[,,,] sayilar = new int[2, 3, 4, 5];
        #endregion
        #region Örnek 2
        //int[,,] sayilar = new int[2, 3, 4];
        //sayilar[0, 0, 1] = 15;
        #endregion

        #endregion
        #region Varyasyonlar Değer Atama
        //int[,] sayilar = {
        //    { 2, 2 , 3}, { 3, 3 , 4}
        //};
        #endregion

        #region Çok Boyutlu Dizilerde Döngü ile Değeri Okuma
        //int[,,] threeDimensionalArray = new int[2, 3, 4]
        //{
        //    {
        //        { 1, 2, 3, 4 },
        //        { 5, 6, 7, 8 },
        //        { 9, 10, 11, 12 }
        //    },
        //    {
        //        { 13, 14, 15, 16 },
        //        { 17, 18, 19, 20 },
        //        { 21, 22, 23, 24 }
        //    }
        //};

        //for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
        //{
        //    for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
        //    {
        //        for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
        //        {
        //            Console.WriteLine(threeDimensionalArray[i, j, k]);
        //        }
        //        Console.WriteLine("");
        //    }
        //}
        #endregion


        #endregion


        #endregion

        #region Düzensiz Diziler
        //Düzensiz diziler; her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir. 
        //Çok boyutlu dizilerden tek farkı, çok boyutlu dizilerin sütun sayılarının sabit düzensiz dizilerin ise her bir elemanın sütun sayısının değişken olmasıdır. 

        //int[][] sayilar = new int[3][];
        //sayilar[0] = [3, 5, 7];
        //sayilar[1] = [2, 4, 6, 8];
        //sayilar[2] = [1, 3, 5, 7, 9];

        //İçteki dizilerin eleman sayısı elde etmek için herbirini toplayıp toplam eleman sayısını bulabiliriz.

        //Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length);

        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    for (int j = 0; j < sayilar[i].Length; j++)
        //    {
        //        Console.WriteLine(sayilar[i][j]);
        //    }
        //}

        #endregion

    }
}