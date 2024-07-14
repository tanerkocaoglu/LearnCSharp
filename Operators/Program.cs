internal class Program
{
	private static void Main(string[] args)
	{
		#region Aritmetik Operatörler

		#region Aritmetik Operatörlerde Geriye Dönüş Değerleri
		//Aritmek operatörler geriye uygun türde bir değer döndürürler.

		#region İnceleme 1
		//int sonuc = 5 + 3; --> 8 (int)
		#endregion
		#region İnceleme 2
		//int x = 5;
		//int y = 3;
		//int sonuc = x * y;
		#endregion
		//Aynı türde olan sayısal değer üzerinde işlem yaparken sonuç türü işlemde kullanılan türdendir.
		#region İnceleme 3

		//double s1 = 5;
		//double s2 = 3;
		//double sonuc = s1 + s2; --> 8.0 (double)
		#endregion
		#region İnceleme 4
		//decimal s1 = 523;
		//decimal s2 = 33;
		//decimal sonuc = s1 % s2; --> 2(decimal)
		#endregion

		#endregion

		#region (int) * (int) = ?

		#endregion
		#region (int) * (double) = ?
		//İki farklı türde sayısal değer üzerinde yapılan aritmetik işlemde sonuç daha büyük olan türde olur.
		//int s1 = 10;
		//double s2 = 3.5;
		//Aritmetik operatörlerde küçük olan tür büyük olan türe bilinçsiz dönüşüm yapar. O yüzden sonuç büyük olan türde olur.
		//double sonuc = s1 + s2;
		#endregion
		#region (byte) * (int) = ?
		//int s1 = 3;
		//byte s2 = 125;
		//int sonuc = s1 - s2;
		#endregion
		#region (byte) * (byte) = ? (Mülakat)
		//Normalde 2 aynı sayısal değer üzerinde işlem yaparken sonuç aynı türde olur. Bu iki değer byte ise sonuç int olur. İstisnai bir durumdur.
		//byte s1 = 10;
		//byte s2 = 20;
		//var sonuc = s1 + s2;
		//Console.WriteLine(sonuc);
		#endregion

		#region Matematiksel İşlemerde Öncelik Sırası
		//Matematikteki işlem öncelik sırası aynen geçerlidir.
		#endregion

		#endregion

		#region Karşılaştırma Operatörleri
		//İki sayısal değer arasında büyüklük, küçüklük ve eşitlik gibi durumları kontrol eder.
		// <(küçüklük) , >(büyüklük), <=(küçük eşitlik), >=(büyük eşitlik), ==(eşitlik), !=(eşit değildir)

		#region Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri
		//Karşılaştırma operatörleri geriye her daim bool türünde bir değer döndürürler.
		//int i1 = 123;
		//int i2 = 125;
		//bool sonuc = i1 < i2;
		//Console.WriteLine(sonuc);
		#endregion

		#endregion

		#region Mantıksal Operatörler
		//Tüm şartlar değerlendirilip, kendine göre sonuç döndüren operatörlerdir.

		#region &&(ve)
		// &&(ve) operatörü, tüm şartlar sağlandığında true döndürür.
		#endregion
		#region ||(veya)
		// ||(veya) operatörü şartlardan en az bir tanesinin yerine getirilmesini bekler.
		// true/false || true/true || false/true 
		#endregion
		#region ^(yada)
		// ^(yada) operatörü, şartlardan sadece bir tanesinin sağlanmasını bekler.
		#endregion

		#region Mantıksal Operatörlerin Kullanım Mantığı
		//Mantıksal operatörler geriye mantıksal değerler döndürürler. True ya da false.

		//bool patates = true, kofte = false;
		//bool sonuc1 = patates && kofte;
		//bool sonuc2 = patates || kofte;
		//bool sonuc3 = patates ^ kofte;
		//Console.WriteLine(sonuc1); --> False
		//Console.WriteLine(sonuc2); --> True
		//Console.WriteLine(sonuc3); --> True


		#endregion
		#region Mantıksal Operatörlerin Geriye Dönüş Değerleri

		#region Örnek
		//Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true)); --> True
		#endregion
		#endregion


		#endregion

		#region Arttırma Azaltma Operatörleri
		//++(arttırma), --(azaltma) operatörleri birer birer arttırma ve azaltma işlemi yaparlar.

		#region Örnek 1
		//int i = 5;
		//Console.WriteLine(i++); //Çıktı : 5 , Bellek : 6
		//Console.WriteLine(++i); //Çıktı : 7 , Bellek : 7
		#endregion
		#region Örnek 2
		//int a = 5;
		//int b = a++;
		//Console.WriteLine(a);
		//Console.WriteLine(b);
		#endregion
		#region Örnek 3
		//int i = 5;
		//int j = ++i;
		//int k = i;
		//j = ++j;
		//Console.WriteLine(i);
		//Console.WriteLine(j);
		//Console.WriteLine(k);
		#endregion
		#endregion

		#region Üzerine Ekleme Yığma Operatörleri
		//+= , -= , *= , /= , %= 
		#endregion

		#region Metinsel İfadelerde Operatörler

		#region + Operatörü
		//Metinsel ifadeler + operatörü ile yanyana birleştirebilirler.

		//string ad = "Veli";
		//int yas = 15;
		//string tamAd = ad + " " + yas;
		//Console.WriteLine(tamAd);


		#endregion
		#region += Operatörü
		//string a = "Merhaba";
		//string b = "Dünya";
		//a += b;
		//Console.WriteLine(a);

		#endregion
		#region == Operatörü
		//string a = "Merhaba";
		//string b = "Dünya";
		//bool sonuc = a == b;
		//bool sonuc2 = a != b;
		//if (a.Length > b.Length)
		//{
		//	Console.WriteLine("A'nın harf sayısı daha fazla");
		//}
		//else
		//{
		//	Console.WriteLine("B'nin harf sayısı daha fazla");
		//}
		#endregion

		#endregion

		#region ! Operatörü

		//Console.WriteLine(!true);
		//int a = 5;
		//int b = 3;
		//Console.WriteLine(a != b);
		//Console.WriteLine(!(a == b));

		#endregion

		#region Ternary Operatörü ? : 
		//Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse tek satırda
		//bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan kalıpsal operatördür.
		//Dönecek değerler aynı türde olmalıdır.
		//string mesaj = "";
		//bool medeniHal = true;
		//mesaj = medeniHal == true ? "Evli" : "Bekar";
		//Console.WriteLine(mesaj);

		#region Birden Fazla Condition Uygulamak
		//int yas = 20;
		//string sonuc = yas < 20 ? "A" : (yas == 20 ? "B" : "C");

		#region Örnek 1 
		//Kullanıcı tarafından girilen sayunın aşağıdaki önergelere göre hesabını gerçekleştiren kodu yazınız.
		// sayi < 3					  ==> sayi * 5
		// sayi > 3 && sayi < 9		  ==> sayi * 3
		// sayi >= 9 &&	sayi%2==0	  ==> sayi * 10
		// sayi % 2 == 1			  ==> sayi
		//int sayi, sonuc;
		//Console.WriteLine("Bir sayı giriniz");
		//sayi = int.Parse(Console.ReadLine());
		//sonuc = sayi < 3 ? sayi * 5 :
		//	(sayi > 3 && sayi < 9 ? sayi * 3 :
		//	(sayi >= 9 && sayi % 2 == 0 ? sayi * 10 :
		//	(sayi % 2 == 1 ? sayi : 0)));

		//Console.WriteLine(sonuc);
		//Console.ReadKey();

		#endregion
		#region Örnek 2
		//Hava durumunu tutan string değişken değerine göre aşağıdaki önergeleri uygulayan programı yazınız.
		//Yağmurlu => "Şemsiye almalısın"
		//Güneşli => "Bol bol d vitamini almalısın"
		//Kapalı => "Yağmur yağabilir"

		//string havaDurumu = "Güneşli", onerge;

		//onerge = havaDurumu == "Yağmurlu" ? "Şemsiye almalısın" :
		//		(havaDurumu == "Güneşli" ? "Bol bol d vitamini almalısın." : "Yağmur yağabilir");
		//Console.WriteLine(onerge);


		#endregion

		#endregion
		#endregion

		#region Assign(Atama) Operatörü
		//int a = 1;
		#endregion

		#region .(Member Access) Operatörü
		//Member access, elimizdeki bir değerin türüne uygun olan metotları, propertyleri, fieldları çağırabilmemizi sağlar.
		//Member access, kodun devamını getirir.

		//int i = 5;
		//i.ToString();
		//Console.WriteLine(i);
		#endregion

		#region Cast Operatörü
		//Genelde tür dönüşümü yaparken kullanılır.

		//1. Boxing -> Unboxing
		//object x = 5;
		//int y = (int)x;

		//2. Bilinçli Tür Dönüşümü
		//int a = 120;
		//short b = (short)a;

		//3. Char -> int || int -> char(ASCII)
		//int ascii = 93;
		//char degisenAscii = (char)ascii;

		//İleride polymorphism durumunda base class referansı ile işaretlenen bir nesneyi kendi türünde de elde edebilmemizi sağlar.

		#endregion

		#region Sizeof Operatörü
		//Verilen türün bellekte kaç byte yer kapladığını int olarak döndürür.

		//Console.WriteLine("int: " + sizeof(int));
		//Console.WriteLine("long: " + sizeof(long));
		//Console.WriteLine("decimal: " + sizeof(decimal));
		#endregion

		#region Typeof operatörü
		//typeof operatörü verilen türün tür bilgisini döndürür. O tür ile ilgili bilgileri almak için kullanılır.
		//İleride reflection konusunda kullanılır. Elimizdeki bir türün reflectionına girmek için kullanılır.

		//Type t = typeof(int); //int türününe ait tüm bilgileri döndürür.
		//Console.WriteLine(t.Name);
		//Console.WriteLine(t.IsPrimitive);
		//Console.WriteLine(t.IsClass);
		//Console.WriteLine(t.IsValueType);

		#endregion

		#region Default Operatörü
		//Belirtilen türün default değerini döndürür.
		//Default değerler her tür için yazılım tarafından tanımlanmış varsayılan değerlerdir.
		//sayisal türlerde 0, char türünde '\0', string türünde null, bool türünde false, referans türlerde null

		//Console.WriteLine(default(decimal)); //0
		//Console.WriteLine(default(string)); //null
		//Console.WriteLine(default(Program)); //null

		#endregion

		#region is Operatörü
		//Boxing'e tabii tutulmuş bir değerin öz değerini kontrol etmek için kullanılır.
		//is operatörü geriye bool türünde bir değer döndürür. true ya da false.

		//object x = true;
		//Console.WriteLine(x is bool);
		//Console.WriteLine(x is int);
		//Console.WriteLine(x is Program);

		//İleride if yapılamanmasında çok tercih ettiğimiz bir operatördür.
		//OOP yapılanmasında polimorfizm is operatörüyle kalıtılmsal durumlardaki nesnelerin türlerini öğrenebileceğiz.

		#endregion

		#region is null Operatörü
		//Bir değişkenin değerinin null olup olmamasını kontrol eden ve sonuç olarak bool döndüren operatördür.

		//string ad = "null";
		//Console.WriteLine(ad is null);

		//is null operatörünü sadece null olabilen türlerde kullanabiliriz.(Referans türlü)
		#endregion

		#region is not null Operatörü
		//Elimizdeki değerin null olup olmadığını kontrol eder ve sonuç olarak bool döndürür.

		//string ad = "null";
		//Console.WriteLine(ad is not null);

		//Sadece null alabilen türlerde kullanılabilir.
		#endregion

		#region as Operatörü
		//Cast operatörünün unboxing işlemine alternatif olarak üretilmiş bir operatördür.
		//as operatörü geriye null döndürceği için değer türlü değişkenlerde kullanılmaz.

		//object x = 5;
		//string y = x as string;
		//Console.WriteLine(y); //null
		#endregion

		#region ?(Nullable) Operatörü
		//C# Prog. dilinde değer türlü değişkenler null değer alamazlar. Bu durumu aşmak için nullable(?) operatörü kullanılır.
		//degisken_turu? degisken_adi = null;

		//int? a = null;
		//Console.WriteLine(a is null);

		//Bir değer türlü değişken nullable yapıldıysa eğer; is null, is not null, as gibi null ile çalışan operatörleri kullanılabilir.

		#region as Örneklendirme
		//object x = 5;
		//int? y = x as int?;
		#endregion

		#endregion

		#region Null Coalescing ?? Operatörü
		//Elimizdeki değişkenin değerin null olma durumuna istinaden farklı bir değer göndermek için kullanılır.
		//?? operatöründe sol ve sağdaki türler aynı olmalıdır.Aksi halde hata alırız.

		//string a = null;
		//Console.WriteLine(a ?? "Mehmet");
		#endregion

		#region ??= Null-Coalescing Assignment Operatörü

		string? a = null;
		Console.WriteLine(a ??= "Taner");

		int? id = null;
		id ??= 1; //id null ise 1 değerini ata. değilse id değerini ata.
		#endregion

		

	}
}