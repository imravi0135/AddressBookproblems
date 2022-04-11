using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBookProblems
{
  class Program
  {
      public static void Main(string[] args)
      {
            //Showing Welcome Message On console.
            Console.WriteLine("Welcome to Address Book Progam \n");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }     
  }
}
   


