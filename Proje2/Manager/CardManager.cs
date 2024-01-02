namespace Proje2;

class CardManager : ICard
{
    public void AddCard(List<Card> toDo, List<Employee> employees)
    {
        string caption = Utility.GetInputFromUser("Caption                                     ");
        string content = Utility.GetInputFromUser("Content                                     ");
        uint size = Utility.GetUIntInputFromUser("Project Size -> XS(1),S(2),M(3),L(4),XL(5)  ", 1, 5, 1);
        string name = Utility.GetInputFromUser("Owner Name                                  ");
        string surname = Utility.GetInputFromUser("Owner Surname                               ");

        Card card = new Card(caption, content, ((ProjectSize[])Enum.GetValues(typeof(ProjectSize)))[size - 1]);

        Employee? employee = employees.SingleOrDefault(p => p.CardId.Equals(card.Id));

        if (employee is not null) employee.CardId = null;

        employee = employees.SingleOrDefault(p => p.Name.Equals(name) && p.Surname.Equals(surname));

        if (employee is null) employee = new Employee(name, surname);

        employee.AssignTask(card);

        toDo.Add(card);

        Console.WriteLine("Card has been created successfully.");
    }

    public void UpdateCard(List<Card> cards, List<Employee> employees)
    {
        string caption = Utility.GetInputFromUser("Caption");

        Card? card = cards.FirstOrDefault(p => p.Caption.Equals(caption));

        if (card is not null)
        {
            caption = Utility.GetInputFromUser("Caption                                     ");
            string content = Utility.GetInputFromUser("Content                                     ");
            uint size = Utility.GetUIntInputFromUser("Project Size -> XS(1),S(2),M(3),L(4),XL(5)  ", 1, 5, 1);
            string name = Utility.GetInputFromUser("Owner Name                                  ");
            string surname = Utility.GetInputFromUser("Owner Surname                               ");

            card.Caption = caption;
            card.Content = content;
            card.Size = ((ProjectSize[])Enum.GetValues(typeof(ProjectSize)))[size - 1];

            Employee? employee = employees.FirstOrDefault(p => p.CardId.Equals(card.Id));

            if (employee is not null) employee.CardId = null;

            employee = employees.FirstOrDefault(p => p.Name.Equals(name) && p.Surname.Equals(surname));

            if (employee is null) employee = new Employee(name, surname);

            employee.AssignTask(card);

            Console.WriteLine("Card has been updated successfully.");
        }
        else
        {
            Console.WriteLine("Card has not been found!");
        }
    }

    public void RemoveCard(List<Card> cards, List<Employee> employees)
    {
        string caption = Utility.GetInputFromUser("Caption");

        Card? card = cards.FirstOrDefault(p => p.Caption.Equals(caption));

        if (card is not null)
        {
            Employee? employee = employees.SingleOrDefault(p => p.CardId.Equals(card.Id));

            if (employee is not null) employee.CardId = null;

            cards.Remove(card);

            Console.WriteLine("Card has been removed successfully.");
        }
        else
        {
            Console.WriteLine("Card has not been found!");
        }
    }
}