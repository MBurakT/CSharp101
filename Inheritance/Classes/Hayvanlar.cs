namespace Inheritance;

public class Hayvanlar : Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine($"{this} adapte olur.");
    }
}

public class Surungenler : Hayvanlar
{
    public Surungenler()
    {
        base.Adaptasyon();
        // base.Beslenme();
    }

    public void Surunme()
    {
        Console.WriteLine($"{this} sürünür.");
    }
}

public class Kuslar : Hayvanlar
{
    public Kuslar()
    {
        base.Beslenme();
        base.Solunum();
        base.Bosaltim();
        base.Adaptasyon();
    }

    public void Ucma()
    {
        Console.WriteLine($"{this} uçar.");
    }
}