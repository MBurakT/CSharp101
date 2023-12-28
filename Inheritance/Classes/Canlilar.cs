namespace Inheritance;

public class Canlilar //internal default
{
    protected void Beslenme() //private default
    {
        Console.WriteLine($"{this} beslenir.");
    }
    protected void Solunum()
    {
        Console.WriteLine($"{this} solur.");
    }
    protected void Bosaltim()
    {
        Console.WriteLine($"{this} boşaltım yapar.");
    }
}