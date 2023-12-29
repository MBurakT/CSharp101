namespace Polymorphism;

public class Hayvanlar : Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine($"{this} adapte olur.");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine($"{this} aktif hareket ederek.");
    }
}

public class Surungenler : Hayvanlar
{
    public Surungenler() { }

    public void Surunme()
    {
        Console.WriteLine($"{this} sürünür.");
    }
}

public class Kuslar : Hayvanlar
{
    public Kuslar()
    {
        base.UyaranlaraTepki();
    }

    public void Ucma()
    {
        Console.WriteLine($"{this} uçar.");
    }
}