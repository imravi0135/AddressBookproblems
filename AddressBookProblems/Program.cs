﻿using System;
using System.Collections.Generic;
namespace AddressBookProblems
{
    class ContactDetails
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zipcode;
        public int PhoneNumber;
        public string EmailId;
        public ContactDetails(string FirstName, string LastName, string Address, string City, string State, int Zipcode, int PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");

            Console.WriteLine("Enter Your First name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Your Zipcode");
            int Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email Id");
            string EmailId = Console.ReadLine();
        }
    }
}
