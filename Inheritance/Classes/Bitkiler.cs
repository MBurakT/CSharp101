namespace Inheritance;

public class Bitkiler : Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine($"{this} fotosentez yapar.");
    }
}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler()
    {
        base.Beslenme(); 
        base.Solunum();
        base.Bosaltim();
        base.Fotosentez();
    }
    
    public void TohumlaCogalma()
    {
        Console.WriteLine($"{this} bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler : Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
        // base.Beslenme();
    }

    public void SporlaCogalma()
    {
        Console.WriteLine($"{this} bitkiler sporla çoğalır.");
    }
}