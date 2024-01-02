namespace Proje2;

class Board
{
    public List<Card> ToDo { get; set; }
    public List<Card> InProgress { get; set; }
    public List<Card> Done { get; set; }

    public Board()
    {
        ToDo = new List<Card>();
        InProgress = new List<Card>();
        Done = new List<Card>();
    }

    public Board(List<Card> toDo, List<Card> inProgress, List<Card> done)
    {
        ToDo = toDo;
        InProgress = inProgress;
        Done = done;
    }

}