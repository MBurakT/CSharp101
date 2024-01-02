namespace Proje2;

class Card
{
    public Guid Id { get; }
    public string Caption { get; set; }
    public string Content { get; set; }
    public ProjectSize Size { get; set; }
    public LineType Line {get;set;}
    public Guid? EmployeeId { get; set; }

    public Card(string caption, string content, ProjectSize size) // for creating new Card
    {
        Id = Guid.NewGuid();
        Caption = caption;
        Content = content;
        Size = size;
        Line = LineType.ToDo;
    }

    public Card(string id, string caption, string content, ProjectSize size, LineType line) // for existing Cards
    {
        Id = new Guid(id);
        Caption = caption;
        Content = content;
        Size = size;
        Line = line;
    }
}