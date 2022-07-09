using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        //  Объявим словарь с двумя значениями
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        static void Main(string[] args)
        {
            // Покажем весь список
            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();
            
            var stopWatch = Stopwatch.StartNew();

            // Попробуем добавить новый контакт, если такого ещё нет
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));
            stopWatch.Stop();

            //  Выведем обновлённый список
            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();

            //  Попробуем достать контакт для изменения данных
            if (PhoneBook.TryGetValue("Диана", out Contact contact))
                contact.PhoneNumber = 79990000001;

            // И покажем результат после изменения
            Console.WriteLine("Список после изменения: ");
            WriteAllContacts();
            Console.WriteLine($"Время для добавления {stopWatch.Elapsed.TotalMilliseconds} милисекунд.");
        }

        // Метод для вывода словаря на консоль
        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
            Console.WriteLine();
        }

        // Класс был изменен. Поле Name мы убрали,
        // так как оно теперь будет ключом
        // для поиска значений в словаре
        public class Contact // модель класса
        {
            public Contact(long phoneNumber, String email) // метод-конструктор
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }
            public long PhoneNumber { get; set; }
            public String Email { get; set; }
        }
    }
}