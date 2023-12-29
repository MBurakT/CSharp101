namespace AbstractClass;

class Program
{
    static void Main(string[] args)
    {
        NewCivic newCivic = new NewCivic();
        NewCorolla newCorolla = new NewCorolla();
        NewFocus newFocus = new NewFocus();

        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}", newCivic.HangiMarka(), newCivic.StandratRengi(), newCivic.StandratRengi());
        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}", newCorolla.HangiMarka(), newCorolla.StandratRengi(), newCorolla.StandratRengi());
        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}", newFocus.HangiMarka(), newFocus.StandratRengi(), newFocus.StandratRengi());

        if (Console.ReadLine() == "clear") Console.Clear();
    }
}