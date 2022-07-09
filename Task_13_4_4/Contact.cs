using System;
using System.Collections.Generic;

namespace Task_13_4_4
{
    public class Contact
    {
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(long phoneNumber, string email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}