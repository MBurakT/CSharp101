//dotnet run --project GenericCollectionsandList/GenericCollectionsandList.csproj
using System;
using System.Collections.Generic;

namespace GenericCollectionsandList;

class Program
{
    static void Main(string[] args)
    {
        // List<T> class
        // System.Collections.Generic
        // T object türündedir.
        // Generic List bir list sınıfı tanımlarken T olarak tip değişkenini alır.
        
        List<string> textsFirst = new();
        List<string> textsSecond = new List<string>();
        List<int> numbersFirst = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> numbersSecond = new List<int>(new int[] { 1, 2, 3, 4, 5 });
        List<char> characters = ['a', 'b', 'c'];
        
        // Generic Liste tanımlama ve eleman ekleme
        List<int> numbers = new List<int>();
        numbers.Add(23);
        numbers.Add(10);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(92);
        numbers.Add(34);

        List<string> colors = new List<string>();
        colors.Add("Kırmızı");
        colors.Add("Mavi");
        colors.Add("Turuncu");
        colors.Add("Sarı");
        colors.Add("Yeşil");

        // Count - listede elaman sayısı bulma
        Console.WriteLine("*Listede eleman sayısı*");
        Console.WriteLine(colors.Count);
        Console.WriteLine(numbers.Count);

        // Foreach ve List.ForEach - listede elemanlara erişim
        Console.WriteLine("*Foreach ve List.ForEach ile elemanlara erişim*");
        foreach (var sayi in numbers)
            Console.WriteLine(sayi);

        foreach (var renk in colors)
            Console.WriteLine(renk);

        numbers.ForEach(sayi => Console.WriteLine(sayi));
        colors.ForEach(renk => Console.WriteLine(renk));

        Console.WriteLine("*Listeden nesneye/veriye göre eleman çıkarma ve indexine göre eleman çıkarma*");
        // Remove - listeden eleman çıkarma
        numbers.Remove(4);
        colors.Remove("Yeşil");

        // RemoveAt - listeden indexine göre eleman çıkarma
        numbers.RemoveAt(0);
        colors.RemoveAt(1);

        numbers.ForEach(sayi => Console.WriteLine(sayi));
        colors.ForEach(renk => Console.WriteLine(renk));

        // Contains - liste içerisinde eleman arama
        Console.WriteLine("*Liste içerisinde eleman arama*");
        if (numbers.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu!");

        // BinarySearch - eleman ile index'e erişme
        Console.WriteLine("*Eleman ile index'e erişme*");
        Console.WriteLine(colors.BinarySearch("Sarı"));

        // Diziyi List'e çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
        List<string> hayvanlarListesi = new List<string>(hayvanlar);

        // Clear - listeyi temizleme
        hayvanlarListesi.Clear();

        // Liste içerisinde nesne tutma -1- 
        Console.WriteLine("*Liste içerisinde nesne tutma*");
        List<Users> users = new List<Users>();

        Users user1 = new Users();
        user1.Name = "Ayşe";
        user1.Surname = "Yılmaz";
        user1.Age = 26;

        Users user2 = new Users();
        user2.Name = "Özcan";
        user2.Surname = "Çalışkan";
        user2.Age = 20;

        users.Add(user1);
        users.Add(user2);

        // Liste içerisinde nesne tutma -2-
        List<Users> yeniListe = new List<Users>();
        yeniListe.Add(new Users()
        {
            Name = "Deniz",
            Surname = "Arda",
            Age = 18
        });

        foreach (Users user in users)
        {
            Console.WriteLine("Kullanıcı Adı: " + user.Name);
            Console.WriteLine("Kullanıcı Soyadı: " + user.Surname);
            Console.WriteLine("Kullanıcı Yaşı: " + user.Age);
        }

        yeniListe.Clear();
    }
}

public class Users
{
    string _name; //private default
    string _surname;
    int _age;

    public string Name { get => _name; set => _name = value; }
    public string Surname { get => _surname; set => _surname = value; }
    public int Age { get => _age; set => _age = value; }
}

public class Users2
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
