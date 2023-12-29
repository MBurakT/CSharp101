namespace Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        TohumluBitkiler tohumlubitki = new TohumluBitkiler();

        Console.WriteLine("     **********");

        Kuslar marti = new Kuslar();

        if (Console.ReadLine() == "clear") Console.Clear();
    }
}