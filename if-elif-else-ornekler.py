Örnek 1: Kullanıcının girdiği sayı sıfırdan küçükse negatif uyarısı veren kodu yazınız.

sayi = int(input("Lütfen bir sayı giriniz : "))

if sayi <0:
    print("{} negatif bir tam sayıdır ".format(sayi))               # / input() negatif bir tam sayıdır
else:
    print("{} pozitif bir tam sayıdır.".format(sayi))                # / input() pozitif bir tam sayıdır


# Örnek 2: Kullanıcı tarafından girilen sayının işaretine göre pozitif, negatif yada nötr yazdıran uygulamayı yapınız.


sayi = int(input("Lütfen bir sayı giriniz : "))

if sayi < 0:
    print("{} negatif bir tam sayıdır ".format(sayi))
elif sayi == 0:
    print("{} nötr bir sayıdır".format(sayi))
else:
    print("{} pozitif bir tam sayıdır.".format(sayi))


Örnek 3: Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme durumunu kontrol eden python uygulamasını yapınız.

** Ehliyet alma koşulu en az 18 ve eğitim durumu lise ya da üniversite olmalıdır.

isim = input("isim : ")
yas=int(input("Yaş : "))
egitim=input("eğitim : ")

if (yas>=18):
    if (egitim=='lise' or egitim=='üniversite'):
        print("{} ehliyet alabilirsiniz".format(isim))
    else:
        print("{} ehliyet alamazsınız çünkü eğitim şartı sağlanmıyor".format(isim))
else:
    print("{} ehliyet alamazsınız çünkü yaş şartı sağlanmıyor.".format(isim))

Örnek 4: Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazdıran python uygulamasını yapınız.

0 -24 => 0

25-44 => 1

45-54 => 2

55-69 => 3

70-84 => 4

85-100 => 5

sinav1=float(input("Sınav1 : "))
sinav2=float(input("Sınav2 : "))
sinav3=float(input("Sınav3 : "))

ortalama=(sinav1+sinav2+sinav3)/3

if (ortalama>=0) and ( ortalama<25):
    print("sınavlar ortalamanız {} , ders notunuz : 0".format(ortalama))
elif (ortalama>=25) and (ortalama<45):
    print("sınavlar ortalamanız {} , ders notunuz : 1".format(ortalama))
elif (ortalama>=45) and (ortalama<55):
    print("sınavlar ortalamanız {} , ders notunuz : 2".format(ortalama))
elif(ortalama>=55) and (ortalama<70):
    print("sınavlar ortalamanız {} , ders notunuz : 3".format(ortalama))
elif(ortalama>=70) and (ortalama<85):
    print("sınavlar ortalamanız {} , ders notunuz : 4".format(ortalama))
elif (ortalama>=85) and (ortalama<=100):
    print("sınavlar ortalamanız {} , ders notunuz : 5".format(ortalama))


