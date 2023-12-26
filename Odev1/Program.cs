#region 1
Console.Write("Numbers you will type: ");
int.TryParse(Console.ReadLine(), out int n);
Print1(n);

static void Print1(int counter)
{
    if (counter > 0)
    {
        Console.Write("Input: ");
        int.TryParse(Console.ReadLine(), out int input);
        if (input % 2 == 0) Console.WriteLine(input);
        Print1(counter - 1);
    }
}
#endregion

#region 2
Console.Write("Numbers you will type: ");
int.TryParse(Console.ReadLine(), out int n);
Console.Write("Control number: ");
int.TryParse(Console.ReadLine(), out int m);
Print2(n, m);

static void Print2(int counter, int control)
{
    if (counter > 0)
    {
        Console.Write("Input: ");
        int.TryParse(Console.ReadLine(), out int input);
        Print2(counter - 1, control);
        if (input % control == 0) Console.WriteLine(input);
    }
}
#endregion

#region 3
Console.Write("Words you will type: ");
int.TryParse(Console.ReadLine(), out int n);
Print3(n);

static void Print3(int counter)
{
    if (counter > 0)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine() ?? "Invalid";
        Print3(counter-1);
        Console.Write(string.Format("{0} ", input));
    }
}
#endregion

#region 4
Console.Write("Sentence: ");
string[] words = Console.ReadLine().Trim().Split(' ');
int totalLetter = 0;

foreach (string s in words)
{
    totalLetter += s.Length;
}

Console.WriteLine(string.Format("Words Count: {0}\nLetter Count: {1}", words.Length, totalLetter));
#endregion
