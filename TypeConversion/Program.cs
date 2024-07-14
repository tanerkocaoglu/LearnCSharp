internal class Program
{
	private static void Main(string[] args)
	{
		#region Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi
		//Tür dönüşümlerinde dönüşüm yapılacak verinin türüne uygun bir hedef tür belirlenmelidir.

		#region Parse Metodu
		//Parse metodu sadece string ifadeleri hedef veri tipine dönüştürmek için kullanılır.

		#region Örnek 1
		//string metin = "123";
		//int sayi = int.Parse(metin);
		//Console.WriteLine(sayi * 5); -->Ekrana 615 yazdırır.
		#endregion
		#region Örnek 2
		//string ad = "Taner";
		//int degisenAd = int.Parse(ad); --> Hata verir. Metinsel ifade sayısal bir ifadeye dönüştürülmeye çalışıldı.
		#endregion
		#region Örnek 3
		//string medeniHal = "Evli";
		//bool degisenMedeniHal = bool.Parse(medeniHal); --> Hata verir. Metinsel ifade mantıksal bir ifadeye dönüştürülmeye çalışıldı.
		//Console.WriteLine(degisenMedeniHal);
		#endregion
		#region Örnek 4
		//string metin = "ab";
		//char degisenMetin = char.Parse(metin); --> Hata verir. Metinsel ifade karaktere dönüştürülmeye çalışıldı.
		//Console.WriteLine(degisenMetin);
		#endregion
		#endregion
		#region Convert
		//Convert metodu ile string ifadeleri sayısal ifadelere dönüştürebiliriz.
		#region Örnek 1
		//string metin = "123";
		//int sayi = Convert.ToInt32(metin); -->"123" ifadesini sayısal bir ifadeye dönüştürdük.
		#endregion
		#region Örnek 2
		//string metin = "3,14";
		//double sayi = Convert.ToDouble(metin); -->"3.14" ifadesini ondalıklı bir ifadeye dönüştürdük.
		#endregion
		#endregion


		#endregion

		#region Diğer İfadelerin Metinsel İfadelere Dönüştürülmesi

		#region Convert Fonskiyonu
		//int sayi = 25;
		//string metineDonusenSayi = Convert.ToString(sayi); -->sayi değişkenini metinsel bir ifadeye dönüştürdük.
		#endregion
		#region ToString()
		//ToString() fonskiyonu tüm değelerde mevcuttur.	

		//float sayi = 3.14f;
		//string degisenSayi = sayi.ToString(); -->sayi değişkenini metinsel bir ifadeye dönüştürdük.
		#endregion

		#endregion

		#region Sayısal İfadelerin Kendi Aralarında Tür Dönüşümleri

		#region Bilinçsiz Tür Dönüşümü
		//Bir sayısal türün kendisinden daha geniş bir aralıktaki sayısal türe dönüştürülmesine bilinçsiz tür dönüşümü denir.

		#region Örnek 1
		//int a = 3000;
		//float f = a; -->int türündeki a değişkenini float türüne dönüştürdük. Fakat bu dönüşüm bilinçsiz bir dönüşümdür.
		#endregion
		#region Örnek 2
		//short sayi = 123;
		//long degisenSayi = sayi; 
		#endregion

		#endregion
		#region Bilinçli Tür Dönüşümü
		//Bir sayısal türün kendisinden daha dar bir aralıktaki sayısal türe dönüştürülmesine bilinçli tür dönüşümü denir.

		//int x = 3000;
		//short y = x; -->Hata verir. Bilinçli tür dönüşümü yapılması gerekmektedir.

		//int x = 3000;
		//short y = (short)x; -->Bilinçli tür dönüşümü yapıldı.

		#region Checked
		//Biliçli tür dönüşümü esnasında bir veri kaybı söz konusu ise runtime'da bizi uyaracak olan kontrol mekanizmasıdır.

		/*checked
		{
			//Veri kaybı söz konusu olan kodları bu scope'un içine yazmalıyız.
			int a = 500;
			byte b = (byte)a;
			Console.WriteLine(b);
		}*/

		#endregion
		#region Unchecked
		//Default olarak çalışan kontrol mekanizmasıdır.

		/*unchecked
		{
			int a = 500;
			byte b = (byte)a;
			Console.WriteLine(b);
		}*/
		#endregion

		#endregion

		#region Bool Türünün Sayısal Türlere Dönüşümü
		//True ise 1, false ise 0 değerini alır.

		//bool b = true;
		//int i = Convert.ToInt32(b); -->b değişkenini sayısal bir ifadeye dönüştürdük.
		#endregion
		#region Sayısal Türlerin Boolen Türüne Dönüşümü
		//Tür dönüşümlerinde değiştirilecek türün hedef türe eşit olması gerekiyor. 
		//0 olan değer false, 0'dan farklı olan değerler true değerini alır.

		//int i = 1;
		//bool b = Convert.ToBoolean(i); -->i değişkenini mantıksal bir ifadeye dönüştürdük(true).
		#endregion
		#region Char Türünün Sayısal Türlere Dönüşümü(ASCII)
		//Bilgisayarda her bir karakterin sayılsal bir karşılığı vardır. Bu karşılıklar ASCII tablosunda tutulur.
		//char a = 'A';
		//int _a = (int)a;
		//Console.WriteLine(_a);

		#endregion
		#region Sayısal Türlerin Char Türüne Dönüşümü
		//int oAscii = 111;
		//int OAscii = 79;
		//Console.WriteLine((char)oAscii);
		//Console.WriteLine((char)OAscii);
		#endregion


		#endregion

	}
}