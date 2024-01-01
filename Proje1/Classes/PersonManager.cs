namespace Proje1;

class PersonManager : IPerson
{
    public void AddPerson(List<Person> rehber, Person person)
    {
        rehber.Add(person);
    }

    public void UpdatePerson(Person person, string phoneNumber)
    {
        person.PhoneNumber = phoneNumber;
    }

    public void RemovePerson(List<Person> rehber, Person person)
    {
        rehber.Remove(person);
    }

    public Person? Search(List<Person> rehber, string name, string surname)
    {
        return rehber.FirstOrDefault(p => p.Name == name && p.Surname == surname);
    }

    public void Sort(List<Person> rehber, bool descending)
    {
        List<Person> temp = rehber.OrderBy(p => p.Name).ToList();

        if (descending) temp.Reverse();

        temp.ForEach(p => Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, Phone Number: {p.PhoneNumber}"));
    }

    public void SearchSortByName(List<Person> rehber, string input)
    {
        rehber.Where(p => p.Name.ToLower().Contains(input) || p.Surname.ToLower().Contains(input)).OrderBy(p => p.Surname).OrderBy(p => p.Name).ToList().ForEach(
            x => Console.WriteLine($"Name: {x.Name}, Surname: {x.Surname}, Phone Number: {x.PhoneNumber}"));
    }

    public void SearchSortByPhoneNumber(List<Person> rehber, string phoneNumber)
    {
        rehber.Where(p => p.Name == phoneNumber).OrderBy(p => p.PhoneNumber).ToList().ForEach(
            x => Console.WriteLine($"Name: {x.Name}, Surname: {x.Surname}, Phone Number: {x.PhoneNumber}"));
    }
}