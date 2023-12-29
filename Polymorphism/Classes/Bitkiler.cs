namespace Polymorphism;

public class Bitkiler : Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine($"{this} fotosentez yapar.");
    }

    public override void UyaranlaraTepki()
    {
        //base.UyaranlaraTepki();
        Console.WriteLine($"{this} pasif hareket ederek.");
    }
}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler()
    {
        base.UyaranlaraTepki();
    }

    public void TohumlaCogalma()
    {
        Console.WriteLine($"{this} bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler : Bitkiler
{
    public TohumsuzBitkiler() { }

    public void SporlaCogalma()
    {
        Console.WriteLine($"{this} bitkiler sporla çoğalır.");
    }
}