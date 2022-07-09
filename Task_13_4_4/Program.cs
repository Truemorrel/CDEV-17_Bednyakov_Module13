using System;
using System.Collections.Generic; // подключаем пространство имён с необобщёнными коллекциями

namespace Task_13_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new Phonebook ()
            {
                ["Игорь"].Add(new Contact { 79990000000, "igor@example.com" }),
                ["Андрей"] = new Contact { 79990000001, "andrew@example.com" },
            };

            // проверяем, что добавилось в список
            foreach (var contact in phoneBook)
            {
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
            }
            AddUniq(men, phoneBook);
        }
        static void AddUniq(Contact contact, Phonebook phoneBook)
        {
            phoneBook.Add(contact);
            var isInList = false;
            foreach (var record in phoneBook)
            {
                isInList = (contact == record) ? contact == record : isInList;
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