Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.Kisakenar = 3;
dikdortgen.Uzunkenar = 4;

Console.WriteLine("Class Alan Hesabı: {0}", dikdortgen.AlanHesapla());

DikdortgenStruct dikdortgenStruct;
dikdortgenStruct.Kisakenar = 3;
dikdortgenStruct.Uzunkenar = 4;

Console.WriteLine("Class Alan Hesabı: {0}", dikdortgenStruct.AlanHesapla());

class Dikdortgen
{
    public int Kisakenar;
    public int Uzunkenar;

    public Dikdortgen() { }
    public Dikdortgen(int kisakenar, int uzunkenar)
    {
        this.Kisakenar = kisakenar;
        this.Uzunkenar = uzunkenar;
    }

    public long AlanHesapla()
    {
        return Kisakenar * Uzunkenar;
    }
}

struct DikdortgenStruct
{
    public int Kisakenar;
    public int Uzunkenar;

    // Parametre almayan yani boş constructor tanımlanamıyor.

    public DikdortgenStruct(int kisakenar, int uzunkenar)
    {
        this.Kisakenar = kisakenar;
        this.Uzunkenar = uzunkenar;
    }

    public long AlanHesapla()
    {
        return Kisakenar * Uzunkenar;
    }
}