namespace Proje1;

class Program
{
    internal static void Run(string[] args, List<Person> rehber, IPerson personManager)
    {
        while (true)
        {
            Console.Write("(1) Yeni Numara Kaydetmek\n" +
            "(2) Varolan Numarayı Silmek\n" +
            "(3) Varolan Numarayı Güncelleme\n" +
            "(4) Rehberi Listelemek\n" +
            "(5) Rehberde Arama Yapmak\n" +
            "(0) Çıkış\n" +
            "Lütfen yapmak istediğiniz işlemin numarasını giriniz: ");

            if (!uint.TryParse(Console.ReadLine(), out uint operation))
            {
                throw new Exception("İşlem geçerli değil!");
            }

            if (operation == 0)
            {
                break;
            }

            if (operation < 1 || operation > 5)
            {
                throw new Exception("İşlem, işlem aralığı dışında!");
            }

            switch (operation)
            {
                case 1:
                    personManager.AddPerson(rehber, CreatePersonFromInputs());
                    break;
                case 2:
                    while (true)
                    {
                        string name = GetInputFromUser("Name");
                        string surname = GetInputFromUser("Surname");

                        Person? person = personManager.Search(rehber, name, surname);

                        if (person is not null)
                        {
                            string checkRemove = GetInputFromUser($"{person.Name} {person.Surname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");

                            if (checkRemove.Equals("y")) personManager.RemovePerson(rehber, person);
                            break;
                        }

                        string removeOperation = GetInputFromUser("(1) Silmeyi Sonlandırma\n(2) Yeniden Deneme\nLütfen yapmak istediğiniz işlemin numarasını giriniz");
                        if (!removeOperation.Equals("2")) break;
                    }
                    break;
                case 3:
                    while (true)
                    {
                        string name = GetInputFromUser("Name");
                        string surname = GetInputFromUser("Surname");

                        Person? person = personManager.Search(rehber, name, surname);

                        if (person is not null)
                        {
                            string phoneNumber = GetInputFromUser("Phone Number");

                            personManager.UpdatePerson(person, phoneNumber);
                            break;
                        }

                        string updateOperation = GetInputFromUser("(1) Güncellemeyi Sonlandırma\n(2) Yeniden Deneme\nLütfen yapmak istediğiniz işlemin numarasını giriniz: ");
                        if (!updateOperation.Equals("2")) break;
                    }
                    break;
                case 4:
                    string order = GetInputFromUser("(1) A-Z Sıralama\n(2) Z-A Sıralama\nLütfen yapmak istediğiniz işlemin numarasını giriniz: ");
                    if (order.Equals(2))
                    {
                        personManager.Sort(rehber, true);
                    }
                    else
                    {
                        personManager.Sort(rehber, false);
                    }
                    break;
                case 5:
                    string choice = GetInputFromUser("(1) İsim ve soyisime göre arama yapma\n" +
                    "(2) Telefon numarasına göre arama yapma\n" +
                    "Lütfen yapmak istediğiniz işlemin numarasını giriniz: ");

                    if (choice.Equals(2))
                    {
                        personManager.SearchSortByPhoneNumber(rehber, GetInputFromUser("Phone Number"));
                    }
                    else
                    {
                        personManager.SearchSortByName(rehber, GetInputFromUser("Name or Surname"));
                    }
                    break;
            }
        }

        string GetInputFromUser(string message)
        {
            Console.Write("{0}: ", message);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                input = GetInputFromUser(message);
            }

            return input.Trim();
        }

        Person CreatePersonFromInputs()
        {
            string name = GetInputFromUser("Name");
            string surname = GetInputFromUser("Surname");
            string phoneNumber = GetInputFromUser("Phone Number");

            return new Person(name, surname, phoneNumber);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args,
            new List<Person>(){
            new Person("Burak", "Turhan", "5555555555"),
            new Person("Den", "Eme", "1111111111"),
            new Person("Kara", "Murat", "2222222222"),
            new Person("Emir", "Timur", "3333333333"),
            new Person("Great", "Alexander", "4444444444")
            },
            new PersonManager());
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            Console.WriteLine("Hata: {0}", exp.Message);
        }
    }
}