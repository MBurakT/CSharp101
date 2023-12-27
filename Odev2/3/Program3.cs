// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

Console.Write("Text: ");
string text = Console.ReadLine() ?? string.Empty;

char[] vowels = text.ToLower(CultureInfo.GetCultureInfo("tr-TR")).Where(p => "aeıioöuü".Contains(p)).Distinct().ToArray();
Array.Sort(vowels);

Console.WriteLine(string.Join(", ", vowels));