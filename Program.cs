// // See https://aka.ms/new-console-template for more information
// using System.Runtime.CompilerServices;
// using System.Xml;

// Console.WriteLine("Hello, World!");

// // tam sayılar (byte , short , int , long)

// int sayi1=10;
// int sayi2=30;
// byte sayi3= 100;
// short sayi4 = 98;
// long sayi5=100;

// Console.WriteLine(sayi3+sayi4+sayi5);
// Console.WriteLine(sayi1+sayi2);

// // ondalıklı sayılar,

// float a = 10.9f;
// double b = 20.5;
// decimal c = 12.3m;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// Console.WriteLine(a+b); // float ile double toplanıyor.

// // string ifadeler (char , string)

// string name = "sedat mengü";
// char ch = 'u';

// Console.WriteLine(name);
// Console.WriteLine(ch);

// // boolean veri tipi (true , false)

// bool isActive = false;
// bool isTrue = true;

// Console.WriteLine(isActive);
// Console.WriteLine(isTrue);


// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

// // /  ders-2


// Console.Write("1.sayı : ");                                         // kullanıcıdan 1.sayıyı istedik
// int sayi11 = int.Parse(Console.ReadLine());                         // kullanıcının girdiği sayıyı program string ifade olarak gördüğünden onu int.Parse ile int bir ifdeye çevirdik ve sayi11 değişkenine atadık.
// Console.Write("2.sayı : ");
// int sayi12 = int.Parse(Console.ReadLine());

// int toplam = sayi11 + sayi12;                                       // sayi11 ve sayi12 ye atanan değerleri toplayarak int veri tipinde toplam adında bir değişkene atadık.

// Console.WriteLine($"girilen sayıların toplamı : {toplam}");         // $"" formatı ile sonucu console a yazdırdık.


// // / örnek : 
// // / 

// Console.Write("1.Sayı : ");
// int sayi21 = int.Parse(Console.ReadLine());
// Console.Write("2.sayı : ");
// int sayi22 = int.Parse(Console.ReadLine());

// int carpim = sayi21*sayi22 ;

// Console.WriteLine($"girilen değerlerin çarpımı : {carpim}");


// /// örnek : 
// /// 
// Console.Write("takım giriniz: ");
// string takim = Console.ReadLine();
// Console.Write("futbolcu giriniz: ");
// string futbolcu = Console.ReadLine();

// Console.WriteLine($"girilen takım {takim} , girilen futbolcu {futbolcu}");


// // rakamsal bir ifadeyi string bir ifadeye çevirme

// bool f = false;
// string d = f.ToString();

// Console.WriteLine(c);


// // veri tipi dönüşü ile ilgili bir örnek :

// // kısa ve uzun kenarları verilen bir dikdörtgenin alan ve çevresini bulma,

// Console.Write("Kısa Kenar Giriniz : ");
// int kisaKenar = int.Parse(Console.ReadLine());
// Console.Write("Uzun Kenar Giriniz : ");
// int uzunKenar = int.Parse(Console.ReadLine());

// int alan = kisaKenar*uzunKenar;
// int cevre = (kisaKenar+uzunKenar)*2;

// Console.WriteLine($"Girilen Kenarlara Göre Alan : {alan}");
// // Console.WriteLine($"Girilen Kenarlara Göre Çevre : {cevre}");


// // Console.Write("Kısa Kenar Giriniz : ");
// // int kisaKenar1 = int.Parse(Console.ReadLine());
// // Console.Write("Uzun Kenar Giriniz : ");
// // var uzunKenar1 = int.Parse(Console.ReadLine());

// // Console.WriteLine($"Girilen Kenarlara Göre Alan : {kisaKenar1*uzunKenar1}");
// // Console.WriteLine($"Girilen Kenarlara Göre Çevre : {(kisaKenar1+uzunKenar1)*2}");


// // string name = "sedat";
// // string surname = "mengü";
// // byte age = 34;

// // Console.WriteLine("my name is sedat mengü , I'am 34 years old.");
// // Console.WriteLine("my name is " + name + " " + surname + " , I'am "+age+" years old.");
// // Console.WriteLine(string.Format("My name is {0} {1} , I'am {2} years old.",name,surname,age));
// // Console.WriteLine($"My name is {name} {surname} , I'am {age} years old.");


// // Console.Write("name : ");
// // string name1 = Console.ReadLine();
// // Console.Write("surname : ");
// // string surname1 = Console.ReadLine();
// // Console.Write("age1 : ");
// // byte age1 = byte.Parse(Console.ReadLine());
// // Console.Write("age2 : ");
// // byte age2 = byte.Parse(Console.ReadLine());

// // Console.WriteLine($"My name is {name1} {surname1} , I'am {age1+age2} years old.");

// // string msg = "hello there. my name is sedat mengü.";

// // Console.WriteLine(msg.Length);                   // yazı karakter uzunluğunu verir.
// // Console.WriteLine(msg.ToLower());                // bütün ifadeyi küçük harf yapar.
// // Console.WriteLine(msg.ToUpper());                // bütün ifadeyi büyük harf yapar.
// // Console.WriteLine(msg.Trim());                   // herhangi bir parametre vermediğimiz için boşluktan ifadeyi böler.
// // Console.WriteLine(msg.TrimStart());              // başlangıçtaki boşluk ifadelerini siler
// // Console.WriteLine(msg.TrimEnd());                // yazı sınundaki boşluk ifadelerini siler.
// // Console.WriteLine(msg.Split()[2]);               // boşluklardan bölerek 2.indexteki ifadeyi döner. (my)
// // Console.WriteLine(msg[1]);                       // 1.indeksteki sayıyı döner.(e)
// // Console.WriteLine(msg.StartsWith("H"));          // ifade H ile mi başlıyor. sonuç boolean
// // Console.WriteLine(msg.StartsWith("h"));          // ifade h ile mi başlıyoru .sonuç boolean
// // Console.WriteLine(msg.StartsWith("hello"));      // ifade hello ile mi başlıyoru. sonuç boolean
// // Console.WriteLine(msg.EndsWith("Ü"));            // ifade Ü ile mi bitiyor. sonuç boolean
// // Console.WriteLine(msg.EndsWith("ü"));            // ifade ü ile mi bitiyor. sonuş boolean
// // Console.WriteLine(msg.EndsWith("mengü"));        // ifade mengü ile mi bitiyor. sonuç boolean
// // Console.WriteLine(msg.EndsWith("mengü."));       // ifade mengü. ile mi bitiyor. sonuç boolean
// // Console.WriteLine(msg.Contains("mengü"));        // mengü idadesini içeriyor mu. sonuç boolean
// // Console.WriteLine(msg.Contains("mengu"));        // mengu ifadesini içeriyor mu. sonuç boolean
// // Console.WriteLine(msg.IndexOf("is"));            // is kaçıncı indexten sonra başlıyor. sonuç sayısal bir değer.
// // Console.WriteLine(msg.Substring(5));             // 5.indexten sonrasını yazdırır.
// // Console.WriteLine(msg.Substring(5,18));          // 5.indexten sonra 18 karakter getirsin.

// // Console.WriteLine(msg.Replace("e","a"));          // "e" karakterlerini "a" karakterleri ile değiştirir.
// // Console.WriteLine(msg.Replace(" ","-"));          // boşluk karakterlerini "-" ile değiltirir.
// // Console.WriteLine(msg.Replace("my",""));          // "my" karakterlerini sildik.

// // Console.WriteLine(msg.Insert(0,"123"));          // 0.karakterden sonra 123 ifadesi eklenir.
// // Console.WriteLine(msg.Insert(msg.Length,"abc")); // msg.length karaketerinden sonra abc ifadesini ekledik.


// // Console.WriteLine(msg.Remove(5));          // 5.indexten sonrasını siler ve kalan ifadeyi return eder.
// // Console.WriteLine(msg.Remove(5,5));          // 5.indexten itibaren 5 karakter siler ve kalanı return eder.

// ////////////////////////////////////////////////////////////////////////////////////////////////////

// // diziler

// using Microsoft.VisualBasic;

// string msg = "hello there. my name is sedat mengü.";
// Console.WriteLine(msg[0]);
// Console.WriteLine(msg[1]);
// Console.WriteLine(msg[2]);
// Console.WriteLine(msg[3]);
// Console.WriteLine(msg[4]);


// var result = msg.Split();


// Console.WriteLine(result[0]);
// Console.WriteLine(result[1]);
// Console.WriteLine(result[2]);
// Console.WriteLine(result[3]);
// Console.WriteLine(result[4]);
// Console.WriteLine(result[5]);
// Console.WriteLine(result[6]);



// string [] isimler = {"ali2","oya2","can2","eda2","pars2"};
// // isimler[0]="ali";
// // isimler[1]="oya";
// // isimler[2]="can";
// // isimler[3]="eda";
// // isimler[4]="pars";

// string[] sehirler = {"adana","ankara","istanbul"};
// sehirler[0]="adana";
// sehirler[1]="ankara";
// sehirler[2]="istanbul";

// int [] rakamlar = new int[3];
// rakamlar[0]=100;
// rakamlar[1]=101;
// rakamlar[2]=102;

// string[] siniflar = {"5/A2","5/B2","5/C2","5/D2","5/E2"};
// // siniflar[0]="5/A";
// // siniflar[1]="5/B";
// // siniflar[2]="5/C";
// // siniflar[3]="5/D";
// // siniflar[4]="5/E";

// string[] ulkeler = new string[7];
// ulkeler[0]="Gana";
// ulkeler[1]="Gine";
// ulkeler[2]="Fas";
// ulkeler[3]="Kore";

// string[] takimlar = new string[5];
// takimlar[1]="Takım1";
// takimlar[1]="Takım1";
// takimlar[2]="Takım1";
// takimlar[3]="Takım1";
// takimlar[4]="Takım1";

// Console.WriteLine($"isim : {isimler[0]},sınıf : {siniflar[0]}");



// string[] siniflar = {"5/A3","5/B3","5/C3","5/D3","5/E3"};


// siniflar.SetValue("ozan",0);

// Console.WriteLine(siniflar[0]);
// Console.WriteLine(siniflar.GetValue(1));
// IndexOf: Belirli bir öğenin dizideki ilk indeksini döndürür.

var msg = "hello world!";
Console.WriteLine(msg[..4]);