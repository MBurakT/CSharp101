namespace Polymorphism;

public class Canlilar // public 'sealed' class Canlilar >> bu sınıftan kalıtım olmasını engellemek için kullanılır
{
    protected void Beslenme() 
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

    public virtual void UyaranlaraTepki()
    {
        Console.WriteLine($"{this} uyaranlara tepki verir.");
    }
}