internal class Program
{
	private static void Main(string[] args)
	{

		#region Değişken Tanımlama

		//degisken_turu degisken_adi;

		// int yas;
		// string ad;
		// bool medenihal;


		#region Ram'in yapısı(Stack)
		/*
		 
		Stack: Değişkenlerin değerlerinin tutulduğu yerdir. Değişkenlerin değerleri burada tutulur.
		Heap: Nesnelerin tutulduğu bölümdür.Nesnelerin referansları burada tutulur.
		Metodların bellek adresleride stack'te tutulur.
		Stack FIFO(First In First Out) yapısına sahiptir. Yani ilk giren değer ilk çıkar.

		int yas;
		string ad;
		string soyad;

		*/
		#endregion

		#region Değişken Tanımlama Kuralları
		/*

		1.Anlamlı İsimler Kullanın
		 int yas;
		 string personelAdi;

		2.Özel karakterler kullanılamaz _(alt çizgi) hariç
		 double stok.adedi hatalı kullanımdır.
		 double stok_adedi olmalıdır.

		3.Sayısal İfadelerde Sayısal Değerler Kullanın
		 int yas = 5;
		 int yas = 5.5; hatalı kullanımdır.

		4.Sayısal İfadeler 
		 int sayi1; doğru kullanım
		 int 1sayi; hatalı kullanım

		5. Bir scope içerisinde aynı isimde birden fazla değişken tanımlanamaz.

		*/


		#endregion

		#region İsimlendirme Kuralları

		/*
		 
		Pascal Case : Her kelimenin ilk harfi büyük yazılır.(AdSoyad,DogumTarihi)
		Camel Case : İlk kelime haricindeki tüm kelimelerin baş harfi büyük yazılır.(satisDurumu,personelAdi,userName)
		Snake Case : Kelimeler arasına alt çizgi eklenir.(ad_soyad,dogum_tarihi)
		 
		*/

		#endregion

		#region Değişken Ssimlerini @ Operatörüyle Tanımlama

		/*
		
		Değişken isimlerinde programatik keyword kullanılamaz. Ancak @ operatörüyle kullanılabilir.

		string static; Hatalıdır.
		string @static; Doğru kullanımdır.
		
		*/

		#endregion

		#endregion

		#region Tanımlanmış Değişkenlere Değer Atama

		//degisken_turu degisken_adi = deger;
		// = atama operatörüdür. Sağdaki değeri sol tarafa atar.

		#region Tanımlama Aşamasında Değer Atama

		// int yas = 25; 25 değerini yas değişkenine atar.
		// string ad = "Ahmet"; Ahmet değerini ad değişkenine atar.

		#endregion

		#region Tanımlandıktan Sonra Değer Atama
		#region Örnek 1
		//int x;
		//x = 5;
		#endregion
		#region Örnek 2
		//int a = 5;
		//int b = 10;
		//string c;
		//c = "hello";
		#endregion
		#region Örnek 3
		//int x = 5;
		//char y = 'a';
		//bool p;
		//decimal d = 3.14m;
		//p = true;
		#endregion
		#endregion
		//Bir değişkene atanan en son değer geçerlidir.
		//int x = 5;
		//x = 10; x değişkeninin değeri 10 olur.

		#region Değişkene Değer Atama Kuralları
		#region Metinsel
		//string adSoyad = "Gençay Yıldız";
		#endregion
		#region Karakter
		//char basHarf = 'G';
		#endregion
		#region Mantıksal
		//bool medeniHal = true;
		#endregion
		#region Sayısal
		//int x = 3;
		//int y = 3000000;
		//byte x = 3;
		//Bir sayısal tür değer aralığına girmeyen değeri alamaz.
		//byte y = 500;
		//int z = 9999999999;
		#endregion
		#region Küsütratlı/Ondalıklı Türler
		//float f = 3.14F;
		//double d = 3.14;
		//decimal de = 3.14M;
		#endregion

		#endregion

		#region (_a, _b) = (a,b) Tuple Türüyle Değer Atama
		//int a = 5;
		//int b = 10;

		//(int a, int b) c;
		//c = (5, 10);
		//(int yas, string adi, bool medeniHal) kisi = (20, "Taner", false);

		(int x, char y) z;
		z = (5, 'a');

		#endregion

		#region Tanımlanmış Değişkenin Değerini Okuma
		//Bir değişkenin değerini okumak için değişkenin adını kullanırız.
		//Bir değişkenin adı assing(=) operatörünün sağında yahut metotların parametrelerinde çağırılıyorsa ilgili değişkenin değeri gönderilir.
		//int x = 5;
		//Console.WriteLine(x);

		#region Kritik 1
		/*
		int a = 5;
		int b = 10;
		int c = b;//c=10
		int d = a;//d=5
		b = a;//b=5
		c = b;//c=5
		*/

		#endregion
		#region Kritik 2
		//int a = 5;
		//a = a; a=5'tir

		#endregion
		#endregion

		#endregion

		#region Değeri Olmayan Değişkenler
		//Class'ta değişken tanımlanırken değer atanmazsa default değeri alır. Main metotunda tanımlanan değişkenlerin değeri olmalıdır.
		//Değeri olmayan değişken çağırılırsa hata alınır.
		//int a;

		#endregion

		#region Değişken Davranışlarına Genel Bakış(ref için farkındalık)

		#endregion

		#region Scope Nedir?
		//Faaliyet alanı anlamına gelir. Değişken ve fonksiyonların erişebilirlik sınırlarını belirleyen alandır.
		//Tanımlamalarda ve algoritmik çalışmalarda karışıklıkları önlemek için kullanılır.
		//C# : Süsli Parantezler {} arasındaki alanlar bir scope'dur.
		//Scope'ta aynı isimde birden fazla değişken tanımlanamaz.
		//Scope'ta tanımlanan değişkenler o scope içerisinde geçerlidir.


		#endregion

		#region Custom Scope Oluşturma
		/*
		int a = 5;
		{
			int b = 10;
			{
				int c = 15;
			}
		}
		{

		}
		*/
		#endregion

		#region Sabitler(const)
		//Const değişkenler tanımlandığında ilk değer atanır ve bu değer değiştirilemez.
		//Bir const tanımlandığında STACK'te ilgili türde alan ayrılacaktır ve ilk atanan değer değiştirilemez.
		//Const değiştirilemez fakat okunabilir.
		//const double pi = 3.14;

		#endregion

		#region Değişken Tanımlama Varyasyonları

		#region Vasyasyon 1
		//int a = 5;
		//int b = 10;
		#endregion

		#region Vasyasyon 2
		//int a = 5, b = 10;
		#endregion

		#endregion

		#region Deep Copy(Derin Kopyalama)
		//Eldeki veri çoğaltılır.
		//Örnek: int a = 5; int b = a; a'nın değeri b'ye kopyalanır.
		//int a = 5;
		//int b = a;

		//a *= 5;	
		//Console.WriteLine(a); --> a'nın değeri 25 olur.
		//Console.WriteLine(b); --> b'nin değeri 5 olur.

		#endregion

		#region Object
		//Object tüm türleri karşılayabilen bir türdür.
		//Tüm türlerin atasıdır.
		//Tüm türler object türünden türetilir.
		//Object türü referans türdür. Fakat değer türlerini de karşılar.
		//Object değişkenlerde ilgili verileri RAM'de object türünde tutarlar. Fakat veriler kendi türlerinde işlenir.

		#region Boxing
		//Object bir türdeki değişkene başka bir türdeki değişkeni atamak için kullanılır.
		//Boxing işlemi sonucunda ilgili değişkenin değeri object türünde tutulur. _yas değişkeni 20 değerini object türünde tutar.

		//int yas = 20;
		//object _yas = 20; --> Boxing işlemi gerçekleşir.

		#endregion
		#region Cast
		//Cast operatörü boxing edilmiş kendi türüne dönüştürme işlemi için kullanılır.
		//Bilinçli tür dönüşümü yapar.
		//Cast operatörü, object olan değişkenin solunda object'i hangi türe dönüştürmek istiyorsak o türü yazarız.

		//int a = 5;
		//object b = a;
		//int c = (int)b;
		#endregion
		#region Unboxing
		//int türünde boxing edilmiş bir veriyi int türünde unboxing işlemi yaparak kullanabiliriz.
		//object _yas = 20;
		//int yas = (int)_yas; --> Unboxing işlemi gerçekleşir.

		#endregion

		#endregion

	}
}


