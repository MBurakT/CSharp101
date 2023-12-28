Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi); // ilk static olan const. çalışır ve 1 kez çalışır

Calisan calisan = new Calisan("Den", "Eme", "IT");

Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

Calisan calisan2 = new Calisan("Hem", "Ham", "IT");
Calisan calisan3 = new Calisan("At", "Baş", "IT");

Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
Console.WriteLine("Toplama işleminin sonucu: {0}", Islemler.Topla(200, 100));
Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.Cıkar(400, 200));

class Calisan
{
    private static int calisanSayisi; //field
    private string Isim;
    private string Soyisim;
    private string Departman;

    public static int CalisanSayisi { get => calisanSayisi; } //property

    static Calisan() //Static constructor'ların erişim belirleyicisi olmaz
    {
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman) //constructor
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cıkar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}