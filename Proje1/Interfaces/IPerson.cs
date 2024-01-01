namespace Proje1;

interface IPerson
{
    void AddPerson(List<Person> rehber, Person person);
    void UpdatePerson(Person person, string phoneNumber);
    void RemovePerson(List<Person> rehber, Person person);
    void Sort(List<Person> rehber, bool descending);
    Person? Search(List<Person> rehber, string name, string surname);
    void SearchSortByName(List<Person> rehber, string input);
    void SearchSortByPhoneNumber(List<Person> rehber, string phoneNumber);
}