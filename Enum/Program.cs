namespace Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Monday);
        Console.WriteLine((int)Days.Monday);

        int sicaklik = 32;

        if (sicaklik <= (int)HavaDurumu.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
        else if (sicaklik >= (int)HavaDurumu.Sicak)
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
        else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.Cok_Sicak)
            Console.WriteLine("Hadi dışarıya çıkalım");

        if (Console.ReadLine() == "clear") Console.Clear();
    }


}

enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    Cok_Sicak = 30
}