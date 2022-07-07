using System;

namespace PhoneBook
{
    public class Contact
    {
        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }

        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}