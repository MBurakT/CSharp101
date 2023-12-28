namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        TohumluBitkiler tohumlubitki = new TohumluBitkiler();

        // Methodlar public >> protected olduğundan dolayı artık doğrudan erişilemiyor
        // tohumlubitki.Beslenme(); 
        // tohumlubitki.Solunum();
        // tohumlubitki.Bosaltim();
        // tohumlubitki.Fotosentez();
        tohumlubitki.TohumlaCogalma();

        Console.WriteLine("**********");

        Kuslar marti = new Kuslar();

        // Methodlar public >> protected olduğundan dolayı artık doğrudan erişilemiyor
        // marti.Beslenme();
        // marti.Solunum();
        // marti.Bosaltim();
        // marti.Adaptasyon();
        marti.Ucma();

        if (Console.ReadLine() == "clear") Console.Clear();
    }
}
