// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Xml;

Console.WriteLine("Hello, World!");

// tam sayılar (byte , short , int , long)

int sayi1=10;
int sayi2=30;
byte sayi3= 100;
short sayi4 = 98;
long sayi5=100;

Console.WriteLine(sayi3+sayi4+sayi5);
Console.WriteLine(sayi1+sayi2);

// ondalıklı sayılar,

float a = 10.9f;
double b = 20.5;
decimal c = 12.3m;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

Console.WriteLine(a+b); // float ile double toplanıyor.

// string ifadeler (char , string)

string name = "sedat mengü";
char ch = 'u';

Console.WriteLine(name);
Console.WriteLine(ch);

// boolean veri tipi (true , false)

bool isActive = false;
bool isTrue = true;

Console.WriteLine(isActive);
Console.WriteLine(isTrue);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

// /  ders-2


Console.Write("1.sayı : ");                                         // kullanıcıdan 1.sayıyı istedik
int sayi11 = int.Parse(Console.ReadLine());                         // kullanıcının girdiği sayıyı program string ifade olarak gördüğünden onu int.Parse ile int bir ifdeye çevirdik ve sayi11 değişkenine atadık.
Console.Write("2.sayı : ");
int sayi12 = int.Parse(Console.ReadLine());

int toplam = sayi11 + sayi12;                                       // sayi11 ve sayi12 ye atanan değerleri toplayarak int veri tipinde toplam adında bir değişkene atadık.

Console.WriteLine($"girilen sayıların toplamı : {toplam}");         // $"" formatı ile sonucu console a yazdırdık.


// / örnek : 
// / 

Console.Write("1.Sayı : ");
int sayi21 = int.Parse(Console.ReadLine());
Console.Write("2.sayı : ");
int sayi22 = int.Parse(Console.ReadLine());

int carpim = sayi21*sayi22 ;

Console.WriteLine($"girilen değerlerin çarpımı : {carpim}");


/// örnek : 
/// 
Console.Write("takım giriniz: ");
string takim = Console.ReadLine();
Console.Write("futbolcu giriniz: ");
string futbolcu = Console.ReadLine();

Console.WriteLine($"girilen takım {takim} , girilen futbolcu {futbolcu}");


// rakamsal bir ifadeyi string bir ifadeye çevirme

bool f = false;
string d = f.ToString();

Console.WriteLine(c);


// veri tipi dönüşü ile ilgili bir örnek :

// kısa ve uzun kenarları verilen bir dikdörtgenin alan ve çevresini bulma,

Console.Write("Kısa Kenar Giriniz : ");
int kisaKenar = int.Parse(Console.ReadLine());
Console.Write("Uzun Kenar Giriniz : ");
int uzunKenar = int.Parse(Console.ReadLine());

int alan = kisaKenar*uzunKenar;
int cevre = (kisaKenar+uzunKenar)*2;

Console.WriteLine($"Girilen Kenarlara Göre Alan : {alan}");
Console.WriteLine($"Girilen Kenarlara Göre Çevre : {cevre}");


Console.Write("Kısa Kenar Giriniz : ");
int kisaKenar1 = int.Parse(Console.ReadLine());
Console.Write("Uzun Kenar Giriniz : ");
var uzunKenar1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Girilen Kenarlara Göre Alan : {kisaKenar1*uzunKenar1}");
Console.WriteLine($"Girilen Kenarlara Göre Çevre : {(kisaKenar1+uzunKenar1)*2}");
