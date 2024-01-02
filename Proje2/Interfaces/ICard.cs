namespace Proje2;

interface ICard // public default
{
    void AddCard(List<Card> toDo, List<Employee> employees);
    void UpdateCard(List<Card> cards, List<Employee> employees);
    void RemoveCard(List<Card> cards, List<Employee> employees);
}