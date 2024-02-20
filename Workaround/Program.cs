// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();

//string mesaj = "Merhaba";
//double tutar = 10000 //db den gelir
//    int sayi= 100;
//bool girisYapmisMi=false;
SelamVer("Engin");
SelamVer("Ahmet");
SelamVer();

int sonuc = Topla(3,5);

//Diziler / Arrays
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "ŞERİFE";
person1.LastName="ÇINAR";
person1.DateOfBirthYear = 1986;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Şerife";

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person1);

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}

static int Topla(int sayi1=5, int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " +sonuc);
    return sonuc;
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogunYili { get; set; }
    public long TcNo { get; set; }
}