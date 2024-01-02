namespace Proje2;

class Employee
{
    public Guid Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Guid? CardId { get; set; }

    public Employee(string name, string surname)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
    }

    public void AssignTask(Card card)
    {
        CardId = card.Id;
        card.EmployeeId = Id;
    }

    public Employee AssignTaskForExistingCards(Guid cardId)
    {
        CardId = cardId;
        return this;
    }
}