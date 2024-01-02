namespace Proje2;

static class Utility
{
    internal static string GetInputFromUser(string message)
    {
        Console.Write($"{message}: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            input = GetInputFromUser(message);

        return input;
    }

    internal static uint GetUIntInputFromUser(string message, uint botLimit, uint topLimit, uint counter = 3)
    {
        if (counter == 0) return 0;

        Console.Write($"{message}: ");

        if (!uint.TryParse(Console.ReadLine(), out uint selection))
        {
            Console.WriteLine("\nError: input is invalid!\n");
            selection = GetUIntInputFromUser(message, botLimit, topLimit, counter - 1);
        }

        if (selection < botLimit || selection > topLimit)
        {
            Console.WriteLine("\nError: input is out of range!\n");
            selection = GetUIntInputFromUser(message, botLimit, topLimit, counter - 1);
        }

        return selection;
    }

    internal static Card CreateCardWithId(string id, string caption, string content, ProjectSize size, LineType line)
    {
        return new Card(id, caption, content, size, line);
    }

    internal static Employee CreateEmployeeWithCardId(string name, string surname, string cardId)
    {
        return new Employee(name, surname).AssignTaskForExistingCards(new Guid(cardId));
    }

    internal static Employee CreateEmployee(string name, string surname)
    {
        return new Employee(name, surname);
    }

    internal static List<Card> ConcatAllListOfBoard(Board board)
    {
        return board.ToDo.Concat(board.InProgress.Concat(board.Done)).ToList();
    }
}