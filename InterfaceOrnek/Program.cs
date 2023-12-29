namespace InterfaceOrnek;

class Program
{
    static void Main(string[] args)
    {
        Focus focus = new Focus();
        Corolla corolla = new Corolla();
        Civic civic = new Civic();

        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}\n", civic.HangiMarka(), civic.StandratRengi(), civic.KacTekerlek());
        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}\n", corolla.HangiMarka(), corolla.StandratRengi(), corolla.KacTekerlek());
        Console.WriteLine("Marka: {0}\nRenk: {1}\nTekerlek: {2}", focus.HangiMarka(), focus.StandratRengi(), focus.KacTekerlek());

        if (Console.ReadLine() == "clear") Console.Clear();
    }
}
