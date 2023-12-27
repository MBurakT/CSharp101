// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System.Collections;

int[] inputs = new int[] { 13, 23, 33, 43, 53, 63, 73, 83, 93, 87, 17, 27, 37, 47, 57, 67, 77, 0, 1, 2 };
float[] numbers = new float[20];

for (int i = 0; i < 20; i++)
{
    Console.Write("Input: ");
    if (float.TryParse(Console.ReadLine(), out float number)) // Console.ReadLine() >> inputs[i].ToString()
    {
        numbers[i] = number;
    }
}

numbers.Sort();
Print(numbers, 3, "of 3 Smallest: ", out float averageOfSmallest);
numbers.Reverse();
Print(numbers, 3, "of 3 Biggest: ", out float averageOfBiggest);
Console.WriteLine("Total Of Averages: " + (averageOfSmallest + averageOfBiggest));

void Print(float[] array, int counter, string message, out float average)
{
    average = 0;

    for (int i = 0; i < counter; i++)
    {
        average += array[i];
    }

    average = Convert.ToSingle(Math.Round(average, 2));
    Console.WriteLine("Total " + message + average);

    average = Convert.ToSingle(Math.Round(average / counter, 2));
    Console.WriteLine("Average " + message + average);
}

static class ArrayExtensions
{
    public static void Sort<T>(this T[] array)
    {
        Array.Sort(array);
    }

    public static void Reverse<T>(this T[] array)
    {
        Array.Reverse(array);
    }
}