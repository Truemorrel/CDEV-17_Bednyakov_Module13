using System;
using System.Collections.Generic; // подключаем пространство имён с необобщёнными коллекциями

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));
            Contact men = new Contact("Peter", 79990000003, "andrew@example.com");

            AddUniq(men, phoneBook);
            // проверяем, что добавилось в список
            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }
        static void AddUniq(Contact contact, List<Contact> phoneBook)
        {
            phoneBook.Add(contact);
            var isInList = false;
            foreach (var record in phoneBook)
            {
                isInList = (contact.Name == record.Name);
            }
            if (!isInList)
            {
                phoneBook.Add(contact);
            }
            phoneBook.Sort((x, y) => string.Compare(x.Name, y.Name));
            foreach (var record in phoneBook)
            {
                Console.WriteLine($"{record.Name}: {record.PhoneNumber}");
            }
        }
    }

}