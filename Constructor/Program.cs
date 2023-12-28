// Söz dizimi
// class sinifAdi
//{
//[Erişim belirleyici] [Veri tipi] OzellikAdi;
//[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
//{
//Metot komutları
//}
//}

//Erişim belirleyiciler
// * Public
// * Private
// * Internal
// * Protected
Console.WriteLine("*****Çalışan 1******");
Calisan calisan1 = new Calisan("Deneme", "Eme", 1806538, "IT");
calisan1.CalisanBilgileri();

Console.WriteLine("*****Çalışan 2******");
Calisan calisan2 = new Calisan();
calisan1.Ad = "Den";
calisan1.Soyad = "Eme";
calisan1.No = 123456;
calisan1.Departman = "Finans";
calisan1.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan() { }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
}