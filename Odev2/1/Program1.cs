// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
//     Negatif ve numeric olmayan girişleri engelleyin.
//     Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//     Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;

// int[] inputs = new int[] { 13, 23, 33, 43, 53, 63, 73, 83, 93, 87, 17, 27, 37, 47, 57, 67, 77, 0, 1, 2 };
ArrayList numbers = new ArrayList(), primenumbers = new ArrayList();

for (int i = 0; i < 20; i++)
{
    Console.Write("Input: ");
    if (uint.TryParse(Console.ReadLine(), out uint number)) // Console.ReadLine() >> inputs[i].ToString()
    {
        if (number < 2)
        {
            numbers.Add(number);
        }
        else if (number == 2)
        {
            primenumbers.Add(number);
        }
        else
        {
            uint j = 2;
            double limit = Math.Sqrt(number);

            for (; j <= limit; j++)
            {
                if (number % j == 0)
                {
                    numbers.Add(number);
                    break;
                }
            }

            if (j > limit)
                primenumbers.Add(number);
        }
    }
}

PrintPrimeNumbersWithAverage(numbers, "          **** Numbers ****");
PrintPrimeNumbersWithAverage(primenumbers, "          **** Prime Numbers ****");

void PrintPrimeNumbersWithAverage(ArrayList arraylist, string message)
{
    arraylist.Sort();
    arraylist.Reverse();

    Console.WriteLine(message);
    uint total = 0;
    foreach (uint u in arraylist)
    {
        total += u;
        Console.Write(u + " ");
    }
    Console.WriteLine("total: " + (total / (double)arraylist.Count).ToString("F2"));
}