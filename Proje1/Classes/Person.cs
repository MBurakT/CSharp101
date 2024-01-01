namespace Proje1;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }

    public Person(string name, string surname, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
    }
}