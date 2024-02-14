// See https://aka.ms/new-console-template for more information

Vatandas vatandas1 = new Vatandas();


//string mesaj = "Merhaba";
//double tutar = 10000 //db den gelir
//    int sayi= 100;
//bool girisYapmisMi=false;
SelamVer("Engin");
SelamVer("Ahmet");
SelamVer();

int sonuc = Topla(3,5);

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}

static int Topla(int sayi1, int sayi2)
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