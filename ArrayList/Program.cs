//dotnet run --project ArrayList/ArrayList.csproj
// System.Collections namespace
// Farklı tipte veri aynı anda tutabilir.
// Boyutu dinamik olarak değişir.

ArrayList liste = new ArrayList();
liste.Add("Ayşe");
liste.Add(2);
liste.Add(true);
liste.Add('A');

// Liste içerisinde verilere erişim
Console.WriteLine("* Liste içerisinde verilere erişim *");
Console.WriteLine(liste[1]);

foreach (var item in liste)
    Console.WriteLine(item);

// AddRange
Console.WriteLine("* AddRange *");
string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
List<int> sayilar = new List<int> { 1, 8, 3, 7, 9, 92, 5 };
liste.AddRange(renkler);
liste.Clear();
liste.AddRange(sayilar);

foreach (var item in liste)
    Console.WriteLine(item);

// Sort
Console.WriteLine("* Sort *");
liste.Sort();

foreach (var item in liste)
    Console.WriteLine(item);

// BinarySearch - eleman index'ine erişim 
Console.WriteLine("* BinarySearch *");
Console.WriteLine(liste.BinarySearch(9));

// Reverse
Console.WriteLine("* Reverse *");
liste.Reverse();
foreach (var item in liste)
    Console.WriteLine(item);

// Clear
Console.WriteLine("* Clear *");
liste.Clear();
foreach (var item in liste)
    Console.WriteLine(item);