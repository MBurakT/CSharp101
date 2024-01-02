namespace Proje2;

class Program
{
    static void Run(string[] args, Board board, List<Employee> employees, IBoard boardManager, ICard cardManager)
    {
        while (true)
        {
            uint selection = Utility.GetUIntInputFromUser(
                string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n\n{6}",
                    "(1) Print List",
                    "(2) Add Card",
                    "(3) Update Card",
                    "(4) Remove Card",
                    "(5) Change Card Status",
                    "(0) Exit",
                    "Lütfen yapmak istediğiniz işlemin numarasını giriniz"),
                0,
                5);

            if (selection == 0) break;

            Console.WriteLine();
            switch (selection)
            {
                case 1:
                    boardManager.ListBoard(board, employees);
                    break;
                case 2:
                    cardManager.AddCard(board.ToDo, employees);
                    break;
                case 3:
                    cardManager.UpdateCard(Utility.ConcatAllListOfBoard(board), employees);
                    break;
                case 4:
                    cardManager.RemoveCard(Utility.ConcatAllListOfBoard(board), employees);
                    break;
                case 5:
                    boardManager.ChangeCardStatus(board);
                    break;
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args,
            new Board(
                new List<Card>(),
                new List<Card>()
                {
                    Utility.CreateCardWithId("26794ad9-70ce-4e5c-962e-c09cbf50353a", "Rehber", "Telefon rehberi uygulaması", ProjectSize.S, LineType.InProgress),
                    Utility.CreateCardWithId("c3129ead-65d4-4bd5-a4d5-258b594ce138", "To Do", "Yapılacaklar uygulaması", ProjectSize.M, LineType.InProgress),
                    Utility.CreateCardWithId("c594942b-43df-47a9-b461-821f2edf7eae", "News", "Haber sitesi uygulaması", ProjectSize.L, LineType.InProgress)
                },
                new List<Card>()),
            new List<Employee>() {
                Utility.CreateEmployeeWithCardId("Burak", "Turhan", "26794ad9-70ce-4e5c-962e-c09cbf50353a"),
                Utility.CreateEmployeeWithCardId("Den", "Eme", "c3129ead-65d4-4bd5-a4d5-258b594ce138"),
                Utility.CreateEmployeeWithCardId("Great", "Alexander", "c594942b-43df-47a9-b461-821f2edf7eae"),
                Utility.CreateEmployee("Emir", "Timur"),
                Utility.CreateEmployee("Kara", "Murat")
            },
            new BoardManager(),
            new CardManager());
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }
    }
}