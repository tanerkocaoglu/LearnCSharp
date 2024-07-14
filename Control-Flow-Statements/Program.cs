internal class Program
{
    private static void Main(string[] args)
    {
        #region Switct Case

        //Switch case,kodun akışında belirli bir şarta göre yöndendirme yapmamızı(farklı algoritma çalıştırmamızı) sağlayan yapılanmadır.
        //Switch case yapısı sadece bir değişkenin değerini sadece eşitlik durumuna göre kontrol eder.
        //Sadece eşiktlik durumu kontrol edilecekse switch case yapısı kullanılabilir.
        //Eşitlik durumu sağlanırsa diğer caselere bakmadan switch bloğundan çıkıp gidecektir.
        //Case bloklarının sıralaması ve default'un yeri önemsizdir.

        /*switch (deger)
		{
		case deger1:
				Console.WriteLine("Değer 1'e eşittir.");
				break;

		case deger2:
				Console.WriteLine("Değer 2'ye eşittir.");
				break;
		default:
				Console.WriteLine("Değer hiçbir şarta uymuyor.");
				break;

		}*/

        #region Örnekler
        //int a = 5;
        //switch (a)
        //{
        //	case 5:
        //		Console.WriteLine("Sayının değeri 5'tir");
        //		break;
        //	case 1:
        //		Console.WriteLine("Sayının değeri 1'dir");
        //		break;
        //	default:
        //		Console.WriteLine("Hiçbiri değil");
        //		break;
        //}


        //string ad = "Ali";
        //switch (ad)
        //{
        //	case "Taner":
        //		Console.WriteLine("Adın Taner'dir");
        //		break;
        //	case "Ali":
        //		Console.WriteLine("Adın Ali'dir");
        //		break;
        //	default:
        //		Console.WriteLine("Adınız bilinmiyor");
        //		break;
        //}
        #endregion


        #region When
        //When ile case'lere ekstra şartlar ekleyebiliriz.

        //int satistutari = 1000;
        //switch (satistutari)
        //{
        //	case 1000 when (3 == 5):
        //		Console.WriteLine("Satış Tutarı 1000'dir ve 3 sayısı 5 sayısına eşittir");
        //      break;
        //	case 1000 when (3 == 3):
        //		Console.WriteLine("Satış Tutarı 1000'dir ve 3 sayısı 3 sayısına eşittir");
        //		break;
        //}

        #endregion

        #region goto : 
        //goto anahtar kelimesi ile belirli bir bloğa atlamamızı sağlar. mantıksal bir yapı oluşturmak için kullanılır.
        //goto keywordunun kullanıldığı case'in eşleştirmesine bakmaksızın direkt olarak case'de belirliten işlemi gerçekleştirecektir.

        //int a = 10;
        //switch (a)
        //{
        //	case 5:
        //		Console.WriteLine(a * 10);
        //		break;
        //	case 6:
        //		Console.WriteLine(a / 5);
        //		break;
        //	//Her ikisinden biri olduğu durumda case 5'e yönlendir.
        //	case 7:
        //	case 10:
        //		goto case 5;
        //}

        #endregion

        #region Switch Expressions
        //Tek satırlı işlemlerde kullanılır.

        #region Eski Yöntem
        //string isim = "";
        //int i = 10;
        //switch (i)
        //{
        //	case 5:
        //		isim = "Taner";
        //		break;
        //	case 7:
        //		isim = "Ali";
        //		break;
        //	case 10:
        //		isim = "Bilinmiyor.";
        //		break;
        //}
        #endregion
        #region Yeni Yöntem

        //int i = 10;
        //string isim = i switch
        //{
        //	10 => "Taner",
        //	5 => "Ali"
        //};
        //Console.WriteLine(isim);


        #endregion
        #region Örnek
        //string mesaj = DateTime.Now.DayOfWeek switch
        //{
        //	DayOfWeek.Monday => "Bugün pazartesi",
        //	DayOfWeek.Tuesday => "Bugün salı",
        //	DayOfWeek.Wednesday => "Bugün çarşamba",
        //	DayOfWeek.Thursday => "Bugün perşembe",
        //	DayOfWeek.Friday => "Bugün cuma",
        //	DayOfWeek.Saturday => "Bugün cumartesi",
        //	DayOfWeek.Sunday => "Bugün pazar",
        //};
        //Console.WriteLine(mesaj);
        #endregion
        #region When ile kullanımı

        //int i = 5;
        //string isim = i switch
        //{
        //    var x when x == 7 && x % 2 == 1 => "a", //i'nin değerini x değişkenine atadık.
        //    var x => "Hiçbiri" //Default durumuna karşılık gelir.
        //};


        #endregion

        #endregion

        #region Tuple Patterns

        #region Örnek
        //int sayi1 = 5;
        //int sayi2 = 10;
        //string mesaj = "";

        //switch (sayi1, sayi2)
        //{
        //    case (5, 10):
        //        mesaj = "5 ile 10";
        //        break;
        //    case (10, 20):
        //        mesaj = "10 ile 20";
        //        break;
        //    default:
        //        break;
        //}

        //string mesaj = (sayi1, sayi2) switch
        //{
        //    (5, 10) => "Taner",
        //    (10, 20) => "Ali"
        //};
        #endregion

        #endregion




        #endregion

        #region if
        //if yapısı, elimizdeki değerin eşitlik dahil tüm karşılaştırmaları yapmamızı sağlayan ve sonuca göre akışı yönlendirmemizi sağlayan bir yapılanmadır.
        // Şart her daim bool tipinde olmalıdır. Karşılaştırma operatörleri ve mantıksal operatörler ile birlikte kullanılır.

        //if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır.

        #region Kritik 1
        //if yapılanmasında illaki else kullanmak zorunda değiliz.

        //int i = 10;
        //if (i == 10)
        //{
        //    Console.WriteLine("i'nin değeri 10'dur.");
        //}

        #endregion
        #region Kritik 2
        //bool değerler için karşılaştırma yapmamıza gerek yoktur.
        //bool medeniHal = true;
        //if (medeniHal)
        //{
        //    Console.WriteLine("Hayırlı olsun");
        //}
        #endregion

        #endregion

        #region if-else
        //Şart sağlanırsa kodun if içinde belirtilen çalışıp şart sağlanmazsa else içinde belirtilen kodun çalışması sağlanır.
        //if-else yapısı birbirini tamamlayan yapılar olup birbirlerinden bağımsız çalışmazlar.
        //şartın false olması durumunda else bloğu tetiklenir.

        #region Örnek
        //int i = 5;
        //if (i == 5)
        //{
        //    Console.WriteLine("i == 5");
        //}
        //else
        //{
        //    Console.WriteLine("i != 5");
        //}
        #endregion

        #region Kritik 1
        //int i = 10;
        //if (i != 10)
        //{
        //    Console.WriteLine("i 10 değildir");
        //}
        //else
        //{
        //    Console.WriteLine("i 10'dur");
        //}
        #endregion
        #region Kritik 2
        //if ve else yapılanmasında if ve else bloklarında aynı işlemi yapacaksak bunları tekrarlı bir şekilde yazmamamız gerekir.
        //Her iki durumda da ortak olacak kodları if else bloğunun dışına yazmamız olayı daha anlaşılır hale getirecektir.

        //int i = 10;
        //if (i == 10)
        //{
        //    Console.WriteLine("i 10'dur");
        //}
        //else
        //{
        //    Console.WriteLine("i 10 değildir");
        //}
        //Console.WriteLine("Merhaba");
        #endregion

        #endregion

        #region if - else if
        //if-else if yapısı, if yapısının birden fazla şartı kontrol etmesini sağlayan yapılanmadır.
        //Eğer hava yağmurlu ise şemsiye al, yağmurlu değil kapalı ise hırka al, değilse tişört al gibi durumlar için kullanılır.

        #region Örnek
        //int sayi = 30;
        //if (sayi > 5 && sayi <= 10)
        //{
        //    Console.WriteLine(sayi * 5);
        //}
        //else if (sayi > 10 && sayi < 30)
        //{
        //    Console.WriteLine(sayi * 10);
        //}
        //else
        //{
        //    Console.WriteLine(sayi);
        //}
        #endregion

        #region Kritik
        //Bazı durumlarda if- else if yapısını kullanmak doğu olmayabilir.

        /*--------------------- Hatalı Kullanım --------------------------*/
        //int sayi = int.Parse(Console.ReadLine());
        //if (sayi > 100 && sayi <= 200)
        //{
        //    Console.WriteLine("100 ile 200 arasında");
        //}
        //else if (sayi > 200 && sayi <= 300)
        //{
        //    Console.WriteLine("200 ile 300 arasında");
        //}
        //else if (sayi > 200 && sayi <= 400)
        //{
        //    Console.WriteLine("200 ile 400 arasında");
        //}

        /*--------------------- Doğru Kullanım --------------------------*/
        //int sayi = int.Parse(Console.ReadLine());
        //if (sayi > 100 && sayi <= 200)
        //{
        //    Console.WriteLine("100 ile 200 arasında");
        //}
        //if (sayi > 200 && sayi <= 300)
        //{
        //    Console.WriteLine("200 ile 300 arasında");
        //}
        //if (sayi > 200 && sayi <= 400)
        //{
        //    Console.WriteLine("200 ile 400 arasında");
        //}



        #endregion


        #endregion

        #region if - else if - .... - else
        //Birden fazla şartın kontrol edilmesi gereken durumlarda kullanılır.

        //int i = 100;
        //if (i > 100)
        //{
        //    Console.WriteLine("i 100'den büyüktür");
        //}
        //else if (i > 50)
        //{
        //    Console.WriteLine("i 50'den büyüktür");
        //}
        //else if (i > 25)
        //{
        //    Console.WriteLine("i 25'den büyüktür");
        //}
        //else
        //{
        //    Console.WriteLine("i 25'den küçüktür");
        //}


        #endregion

        #region Scopesuz if yapısı
        //if yapılanmasında tek satırlık bir işlem gerçekleştiriliyorsa süslü parantez kullanmamıza gerek yoktur.
        //Eğer ki birden fazla işlem yapılacaksa süslü parantez kullanılmalıdır.Aksi halde yazılan ilk bloğu işleme alır.

        //if (true)
        //    Console.WriteLine("Taner");

        #endregion

        #region Senaryo 1
        //Klavyeden iki ürünün fiyatının girildiğnde toplam fiyat 200 TL'den fazla ise, 2. ürüne %25 indirim yapar ödenecek tutarı ekrana yazdırır.

        //int birinciUrun, ikinciUrun, indirimliFiyat, indirimsizFiyat;
        //Console.Write("1. Ürünün fiyatını giriniz: ");
        //birinciUrun = int.Parse(Console.ReadLine());
        //Console.Write("2. Ürünün fiyatını giriniz: ");
        //ikinciUrun = int.Parse(Console.ReadLine());
        //indirimsizFiyat = birinciUrun + ikinciUrun;
        //if (indirimsizFiyat > 200)
        //{
        //    ikinciUrun = (ikinciUrun * 75) / 100;
        //    indirimliFiyat = birinciUrun + ikinciUrun;
        //    Console.Write($"İndirimsiz fiyat: {indirimsizFiyat} \nÖdenecek indirimli tutar: {indirimliFiyat}");
        //}
        //else
        //{
        //    Console.Write(indirimsizFiyat);
        //}


        #endregion

        #region Senaryo 2
        //Belirlenen kullanıcı adı veya şifre doğru girildiğinde "Giriş Başarılı", yanlış girildiğinde ise "Kullanıcı adı veya şifre hatalı" mesajını veren console uygulaması.
        //string Username, Password;
        //Console.Write("Kullanıcı adı giriniz: ");
        //Username = Console.ReadLine();
        //Console.Write("Şifre giriniz: ");
        //Password = Console.ReadLine();

        #region 1.Çözüm

        //if (Username == "Taner" || Username == "taner" && Password == "123")
        //{
        //    Console.WriteLine("Giriş başarılı");
        //}
        //else
        //{
        //    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
        //}

        #endregion
        #region 2.Çözüm
        //Console.WriteLine(Username == "taner" && Password == "123" ? "Giriş başarılı" : "Kullanıcı adı veya şifre hatalı");
        #endregion
        #region 3.Çözüm
        //string mesaj = (Username, Password) switch
        //{
        //    ("Taner", "123") => "Giriş başarılı",
        //    _ => "Kullanıcı adı veya şifre hatalı"
        //};
        //Console.WriteLine(mesaj);
        #endregion
        #endregion

        #region Senaryo 3
        //Kullanıcıdan alınan iki sayının ve yapılacak işlem türünün (+,-,*,/) seçilmesiyle, sonucu hesaplayan konsol uygulaması.

        //char islem;
        //int sayi1, sayi2;

        //Console.Write("1.Sayıyı giriniz: ");
        //sayi1 = int.Parse(Console.ReadLine());
        //Console.Write("2.Sayıyı giriniz: ");
        //sayi2 = int.Parse(Console.ReadLine());
        //Console.Write("Yapmak istediğiniz işlemi seçiniz:\nToplama: +\nFark: -\nÇarpım: *\nBölüm: /\n");
        //islem = char.Parse(Console.ReadLine());

        #region 1.Çözüm

        //switch (islem)
        //{
        //    case '+':
        //        Console.WriteLine($"İki sayının toplamı: {sayi1 + sayi2}");
        //        break;
        //    case '-':
        //        Console.WriteLine($"İki sayının farkı: {sayi1 - sayi2}");
        //        break;
        //    case '*':
        //        Console.WriteLine($"İki sayının çarpımı: {sayi1 * sayi2}");
        //        break;
        //    case '/':
        //        Console.WriteLine($"İki sayının bölümü: {sayi1 / sayi2}");
        //        break;
        //}
        #endregion
        #region 2.Çözüm

        //int sonuc = islem switch
        //{
        //    '+' => (sayi1 + sayi1),
        //    '-' => (sayi1 - sayi1),
        //    '*' => (sayi1 * sayi1),
        //    '/' => (sayi1 / sayi1),
        //};
        //Console.WriteLine(sonuc);

        #endregion
        #region 3.Çözüm
        //Console.WriteLine(islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1 - sayi2 : (islem == '*' ? sayi1 * sayi2 : sayi1 / sayi2)));
        #endregion

        #endregion

        #region Senarya 4
        //Girilen sayının değeri 10 değil ise ekrana 'Yanlış sayı' yazdıralım

        //int sayi;
        //Console.WriteLine("Bir sayı giriniz: ");
        //sayi = int.Parse(Console.ReadLine());
        #region Çözüm 1
        //if (sayi != 10)
        //{
        //    Console.WriteLine("Yanlış sayı");
        //}
        #endregion
        #region Çözüm 2
        //Console.WriteLine(sayi != 10 ? "sayı yanlış" : "");
        #endregion
        #region Çözüm 3
        //string sonuc = sayi switch
        //{
        //    10 => "",
        //    _ => "Sayı yanlış"
        //};
        //Console.WriteLine(sonuc);
        #endregion
        #endregion

        #region Senaryo 5
        //Girilen sayının negatif yada pozitif olduğunu gösteren konsol uygulaması

        //int sayi = int.Parse(Console.ReadLine());

        #region Çözüm 1
        //string sonuc = "";
        //if (sayi < 0)
        //    sonuc = "Negatif";
        //else
        //    sonuc = "Pozitif";
        #endregion
        #region Çözüm 2
        //string mesaj = sayi switch
        //{
        //    var x when x < 0 => "Negatif",
        //    var _ => "Pozitif"
        //};
        //Console.WriteLine(mesaj);
        #endregion
        #region Çözüm 3
        //Console.WriteLine(sayi < 0 ? "Sayı negatif" : "Sayı pozitif");
        #endregion

        #endregion

        #region Pattern Matching

        #region Type Pattern

        //object ad = "Taner";
        //if (ad is string x)
        //{
        //    Console.WriteLine(x);
        //}
        #endregion

        #region Contsant Pattern
        //Elimizdeki veriyi sabit bir değer ile karşılaştırmamızı sağlayan operatördür.
        // contsant pattern == karşılaştırmasını yapan operatördür.

        //object ad = "Taner";
        //if (ad is "Taner")
        //{
        //    Console.WriteLine("Taner");
        //}

        #region Kritik
        //is operatörü bir değişkenin türünü sormamızı sağlayan bir operatördür. Bu operatörün kullanıldığı değişkenin türü referans türlü olamak zorunda değildir. 
        //İsterseniz değişken türlü değişkenlerde de is operatörünü kullanabilirsiniz.

        //int a = 5;
        //Console.WriteLine(a is int);
        //Console.WriteLine(a is string);
        //Console.WriteLine(a is decimal);

        /*---Const pattern doğru kullanım----*/

        //Console.WriteLine(a is 5); 

        //Eğer ki is operatörü ile bir değişkenin değerini == operatörünün sorumluluğuyla check ediliyorsa işte buna constant patter denilmektedir.


        #endregion

        #endregion

        #region var Pattern

        #region Kritik 1

        //object x = "taner";
        //_x'in türü runtime sırasında belirlenecektir.
        //if (x is var _x)
        //{
        //    Console.WriteLine(_x);
        //}

        #endregion
        #region Kritik 2
        //y'nin türü derleme zamanı otomatik olarak belirlenirken, z'nin türü runtime belirlenecektir.

        //object x = "taner";
        //var y = "ali";
        //if (x is var z)
        //{
        //    Console.WriteLine(z);
        //}


        #endregion

        #endregion

        #region Recursive Pattern
        //Tür kontrolü yaptığı için type pattern'ı kapsamaktadır.
        //Tür kontrolü contstant paternıda kapsamaktadır.

        #endregion

        #region Genel Kritik

        //object x = "Taner";

        //bool result = x is string o;
        //Console.WriteLine(o); //Hata verecektir. o'nun null olma ihtimali olduğu için.

        //bool result2 = x is var p;
        //Console.WriteLine(p); //Hata vermeyecektir. p'nin null olma ihtimali olmadığı için.null olma durumu runtimeda kontrol edilir.


        #endregion

        #endregion
    }

}