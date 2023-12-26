// Recursive- Öz yinelemeli Metotlar
// 3^4 = 3x3x3x3

int result = 1;
for (int i = 1; i < 5; i++)
    result = result * 3;
Console.WriteLine(result);//81

Islemler instance = new();
Console.WriteLine(instance.Expo(3, 4));//81
Console.WriteLine(instance.FibonacciSerisi(4));//f(4) = 3 (0,1,1,2,3,5,8,13,21,...) 

// Extension Metotlar
// Extension metotlar static bir class içerisinde static bir metot olarak yazılmalılar.
// Extension metotta tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

string ifade = "Den Eme 123";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);

if (sonuc)
    Console.WriteLine(ifade.RemoveWhiteSpaces());

Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
dizi.SortArray();
dizi.EkranaYazdir();

int sayi = 5;
Console.WriteLine(sayi.isEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());