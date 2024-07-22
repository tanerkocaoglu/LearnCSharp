internal class Program
{
    private static void Main(string[] args)
    {
        #region String
        //String referans türlü olduğu halde programlama dilinde bir keyword barındırdan tek değerdir.


        #region Null - Empty  Durumları,Farkları

        #region Null
        //Bir değişken eğer ki null alıyorsa ilgili değişkenin bellekte herhangi bir alanı tahsis etmediği anlamına gelir.
        //Arsa yok.
        //Değer türlü değişkenler null olamazlar. Sadece referans türlü değişkenler null olabilirler.
        #endregion
        #region Empty
        //Bir değişken eğer ki empty ise du değişkenin değeri yok anlamına gelir. Yani bellekte alan tahsisi yapılır.
        //Arsa var ama üzerinde bir bina yok.
        //Tüm değerlere empty atanabilir.
        //Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumunu oluşturur.
        //Default değerlerin olduğu durumlar empty durumunu oluşturur.
        //Empty dendiğinde aklıma string'e "" değerinin verilmesi gelmesi yeter.
        //null bellekte yer kaplamaz ama empty yer kaplar.
        #endregion
        #region IsNullOrEmpty
        //Elimizdeki string ifadelerin işleme tabii tutulmadan önce mutlaka kontrol edilmesi gerekmektedir.

        //string x = "";
        //Eğer ki değer null ise ya da empty ise true değilse false döner.
        //if (string.IsNullOrEmpty(x))
        //{

        //}
        #endregion
        #region IsNullOrWhiteSpace
        //Elimizdeki string ifadenin null,empty veya boşluk karakterlerinden oluşup oluşmadığını kontrol eder. Geriye bool döner.
        //string x = "   ";
        //if (string.IsNullOrWhiteSpace(x))
        //{

        //}
        #endregion
        #endregion
        #region String - char Dizisi
        //string ifadeler esasında bir char dizisidir. Yani yazılım açısından string bir ifade yoktur. Karaktererin bir araya gelmesiyle oluşan bir dizi vardır.
        //string ifadeler char dizisinden oluştuğu için referans türlüdür.

        #region Döngü ile string ifadenin değerlerini yazdırma
        //string metin = "sebepsiz boş yere ayrılacaksan";
        //foreach (var item in metin)
        //{
        //    Console.WriteLine(item);
        //}
        //for (int i = 0; i < metin.Length; i++)
        //{
        //    Console.WriteLine(metin[i]);
        //}
        #endregion

        #endregion
        #region String ifadelerde + operatörü
        //İki string ifade arasında birleştirme görevi görür.
        //string a = "Merhaba", b = "Dünya";
        //Console.WriteLine(a, b);
        //Bir string ifade ile herhangi bir tür + operatörüyle işleme tabi tutulabilir.
        //+ operatörü object + string davranışı sergilemektedir.
        #endregion
        #region String Formatlandırma
        //string isim = "Taner", soyad = "KOCAOĞLU", tcNo = "12312312312";
        //int yas = 20;
        //bool medeniHal = default;
        //Console.WriteLine($"TC NO : {tcNo} olan {isim} {soyad} adlı şahsın bilgileri | Yaş : {yas} | Medeni Hal : {(medeniHal ? "Evli" : "Bekar")}");
        //Console.WriteLine("Adı: {0}\nSoyadı: {1}\nMedeni Hal: {2}", isim, soyad, medeniHal ? "Evli" : "Bekar");
        #endregion
        #region String Kaçış Karakterleri
        // \(Backword slash) işareti kendisinden sonra gelen karakterin özel karakter olmadığını, metinsel bir değer olduğunu ifade eder. 
        //  \ yanına illaki özel bir karakter bekler.

        #endregion
        #region @(Verbatim Strings) Operatörü

        #region 1.Kullanım
        //Bir değişken gibi yapılanma isimlerinin programatik bir keyword'e karşılık gelmesi mümkün değildir. Bu durumda @ operatörü kullanılır.

        //int @using = 5;
        #endregion
        #region 2.Kullanım
        //string metin = @"hava çok ""güzel""";
        #endregion
        #region 3.Kullanım
        //string metin = @"alkdjsa 
        //                 kldjşaslj 
        //                 dşasldk";
        #endregion

        #endregion


        #region String Fonksiyonları
        //string metin = "Benim adım Taner KOCAOĞLU. Giresunluyum. 20 yaşındayım.";

        #region Contains
        //Console.WriteLine(metin.Contains("Taner"));
        #endregion
        #region StarsWith
        //Console.WriteLine(metin.StartsWith("ç"));
        #endregion
        #region EndsWith
        //Console.WriteLine(metin.EndsWith("ner"));
        #endregion
        #region Equals
        //Elimizdeki metinsel ifade ile herhangi bir metinsel ifadenin eşit olup olmaması durumunu kontrol edip bool değer döndürür.
        //metin.Equals("ahmet"); //false
        #endregion
        #region Compare
        //Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak sayısal bir değer döndürür. 0 eşit, -1 küçük, 1 büyük. 

        //Console.WriteLine(string.Compare(metin, "Z"));
        #endregion
        #region CompareTo
        //Daha kullanışlı

        //Console.WriteLine(metin.CompareTo("asd"));
        #endregion
        #region IndexOf
        //Verilen değerin string ifade içerisinde olup olmadığını kontrol eder. Eğer varsa index numarasını döndürür. Yoksa -1 döndürür.
        //IndexOf metodu aranan değerin ilk bulunduğu index numarasını döndürür.

        //Console.WriteLine(metin.IndexOf("adım"));
        #endregion
        #region Insert
        //Elimizdeki metinsel ifadeye bir değer eklememizi sağlayan fonksiyondur.

        //string metin2 = metin.Insert(0, "Merhaba "); 
        //Console.WriteLine(metin2); 
        #endregion
        #region Remove
        //Metinsel ifadeleri indexel olarak silmemi sağlayan fonksiyondur.
        //Insert'te olduğu gibi orjinal metinsel ifadeyi değiştirmez. Yeni bir metinsel ifade döndürür.

        //metin.Remove(5); //5. index'ten sonrasını siler.
        //metin.Remove(5, 2); //5. index'ten başlayarak 2 karakter siler.
        #endregion
        #region Replace
        //Elimizdeki metinsel ifadeleri veya karakterleri belirtilen diğer karakterler ile değiştirmemizi sağlayan fonksiyondur. 
        //Sonuç olarak string üretecek ve geriye string bir değer döndürecektir.

        //metin.Replace("Taner", "Ali");
        #endregion
        #region Split
        //Metinsel ifadeyi verilen değeri ayraç olarak kullanıp parçalayan ve sonucu string dizisi olarak döndüren fonksiyondur.

        //string[] dizi = metin.Split(' '); //Boşluk karakterine göre parçalama işlemi yapar.
        //string[] dizi2 = metin.Split(' ', 'a');
        #endregion
        #region Substring
        //Metinsel ifadenin belirli bir aralığını elde etmemizi sağlar.
        //metin.Substring(5); //5. index'ten sonrasını alır.
        //metin.Substring(5, 2); //5. index'ten başlayarak 2 karakter alır.
        //metin.Substring(metin.Length - 5); //Metinsel ifadenin son 5 karakterini alır.
        #endregion
        #region Trim
        //Metinsel ifadelerin varsa solundaki ve sağındaki boşluk karakterlerini temizleyen fonksiyondur.

        //Console.WriteLine("Taner KOCAOĞLU");
        //Console.WriteLine("   Taner KOCAOĞLU   ".Trim());
        #endregion

        #endregion
        #region String Fonksiyonları Örnek 1
        //Adımızın ilkten 3. soyadımızın sondan 5.karakterini getirelim.

        //string adSoyad = "Taner KOCAOĞLU";

        #region 1.Çözüm
        //Console.WriteLine(adSoyad[2]);
        //Console.WriteLine(adSoyad[^5]);
        #endregion
        #region 2.Çözüm
        //string dizi = adSoyad[2..^4];
        //Console.WriteLine(dizi[0]);
        //Console.WriteLine(dizi[^1]);
        #endregion


        #endregion
        #region Örnek 2
        //Girilen metnin içerisinde kaç adet 'n' karakterinin olduğunu bulalım. 
        //Console.WriteLine("Lütfen bir metin giriniz: ");
        //string metin = Console.ReadLine();
        //int sayac = 0;
        //for (int i = 0; i < metin.Length; i++)
        //{
        //    if (metin[i] == 'n')
        //    {
        //        sayac++;
        //    }
        //}
        //Console.WriteLine($"Metinizde geçen n harfi sayısı : {sayac}");
        #endregion
        #region Örnek 3
        //Girilen metindeki kelime sayısını bulalım.

        //Console.WriteLine("Lütfen bir metin giriniz: ");
        //string metin = Console.ReadLine();

        #region Çözüm 1
        //string[] dizi = metin.Split(' ');
        //Console.WriteLine(dizi.Count());

        #endregion
        #region Çözüm 2
        //int sayac = 1;
        //for (int i = 0; i < metin.Length; i++)
        //{
        //    if (metin[i] == ' ')
        //    {
        //        sayac++;
        //    }
        //}
        //Console.WriteLine(sayac);
        #endregion
        #region Çözüm 3
        //int sayac = 0;
        //while (true)
        //{
        //    int index = metin.IndexOf(' ');
        //    if (index == -1)
        //    {
        //        break;
        //    }

        //    sayac++;

        //    metin = metin.Substring(index + 1);
        //}
        //Console.WriteLine(sayac);
        #endregion

        #endregion

        #endregion
    }
}