using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBookProblems
{
  class Program
    {
      public static void Main(string[] args)
        {
            int input = 0;
            
            
                Console.WriteLine("Choose 1: Family contacts");
                Console.WriteLine("Choose 2: Friends contacts");
                Console.WriteLine("Choose 0: Exit");

                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        FamilyContact familyContact = new FamilyContact();
                        int option = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 0: To Exit");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        familyContact.AddContact();

                                        continue;
                                    case 2:
                                        familyContact.GetContact();
                                        continue;
                                    case 3:
                                        Console.WriteLine("Enter first name");
                                        string key = Console.ReadLine();
                                        familyContact.EditContacts(key);
                                        break;
                                    case 4:
                                        familyContact.DeleteContacts();
                                        break;
                                    case 0:
                                        Console.WriteLine("Exit");
                                        break;
                                    default:
                                        Console.WriteLine("Choose valid Option");
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("choose an option");
                            }
                        } while (option != 0);
                        break;
                    case 2:
                        FriendsContact friendsContact = new FriendsContact();
                        int options = 0;
                        do
                        {
                            Console.WriteLine("Choose 1: To Add a Contact");
                            Console.WriteLine("Choose 2: To get Contacts");
                            Console.WriteLine("Choose 3: To Edit a contact");
                            Console.WriteLine("Choose 4: To Delete a Contact");
                            Console.WriteLine("Choose 0: To Exit");
                            try
                            {
                                options = int.Parse(Console.ReadLine());
                                switch (options)
                                {
                                    case 1:
                                        friendsContact.AddContact();
                                        continue;
                                    case 2:
                                        friendsContact.GetContact();
                                        continue;
                                    case 3:
                                        Console.WriteLine("Enter first name");
                                        string key = Console.ReadLine();
                                        friendsContact.EditContacts(key);
                                        break;
                                    case 4:
                                        friendsContact.DeleteContacts();
                                        break;
                                    case 0:
                                        Console.WriteLine("Exit");
                                        break;
                                    default:
                                        Console.WriteLine("Choose valid Option");
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please choose an option");
                            }
                        } while (options != 0);
                        break;
                }
        }
    }
}
   


