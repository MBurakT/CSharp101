namespace Proje2;

class BoardManager : IBoard
{
    public void ListBoard(Board board, List<Employee> employees)
    {
        SubListBoard("TODO", board.ToDo, employees);
        SubListBoard("IN PROGRESS", board.InProgress, employees);
        SubListBoard("DONE", board.Done, employees);
    }

    private void SubListBoard(string message, List<Card> cards, List<Employee> employees)
    {

        Console.WriteLine($"{message}\n************************");

        string total = string.Empty;

        foreach (Card c in cards)
        {
            Employee? emp = employees.SingleOrDefault(p => p.CardId.Equals(c.Id));

            string employeeFullName = emp is null ? string.Empty : $"{emp.Name} {emp.Surname}";

            total += string.Format("Başlık      : {0}\nİçerik      : {1}\nAtanan Kişi : {2}\nBüyüklük    : {3}\n-\n", c.Caption, c.Content, employeeFullName, c.Size);
        }

        if (string.IsNullOrEmpty(total))
        {
            Console.WriteLine("~ BOŞ ~\n");
        }
        else
        {
            Console.WriteLine(total.Substring(0, total.Length - 3) + "\n");
        }
    }

    public void ChangeCardStatus(Board board)
    {
        string caption = Utility.GetInputFromUser("Caption");

        Card? card = board.ToDo.FirstOrDefault(p => p.Caption.Equals(caption));

        if (card is not null)
        {
            uint line = Utility.GetUIntInputFromUser("Line -> TODO(1), IN PROGRESS(2), DONE(3) ", 1, 3);

            if (line == 0) return;

            card.Line = ((LineType[])Enum.GetValues(typeof(LineType)))[line-1];

            board.ToDo.Remove(card);

            switch (line)
            {
                case 1:
                    board.ToDo.Add(card);
                    break;
                case 2:
                    board.InProgress.Add(card);
                    break;
                case 3:
                    board.Done.Add(card);
                    break;
            }

            Console.WriteLine("Card Status has been changed successfully.");
            return;
        }

        card = board.InProgress.FirstOrDefault(p => p.Caption.Equals(caption));

        if (card is not null)
        {
            uint line = Utility.GetUIntInputFromUser("Line -> TODO(1), IN PROGRESS(2), DONE(3) ", 1, 3);

            if (line == 0) return;

            card.Line = ((LineType[])Enum.GetValues(typeof(LineType)))[line-1];

            board.InProgress.Remove(card);

            switch (line)
            {
                case 1:
                    board.ToDo.Add(card);
                    break;
                case 2:
                    board.InProgress.Add(card);
                    break;
                case 3:
                    board.Done.Add(card);
                    break;
            }

            Console.WriteLine("Card Status has been changed successfully.");
            return;
        }

        card = board.Done.FirstOrDefault(p => p.Caption.Equals(caption));

        if (card is not null)
        {
            uint line = Utility.GetUIntInputFromUser("Line -> TODO(1), IN PROGRESS(2), DONE(3) ", 1, 3);

            if (line == 0) return;

            card.Line = ((LineType[])Enum.GetValues(typeof(LineType)))[line-1];

            board.Done.Remove(card);

            switch (line)
            {
                case 1:
                    board.ToDo.Add(card);
                    break;
                case 2:
                    board.InProgress.Add(card);
                    break;
                case 3:
                    board.Done.Add(card);
                    break;
            }

            Console.WriteLine("Card Status has been changed successfully.");
            return;
        }

        Console.WriteLine("Card has not been found!");
    }
}