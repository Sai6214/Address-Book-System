using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- WELCOME TO THE ADDRESS BOOK PROGRAM -----------------");
            Console.WriteLine();
            Console.WriteLine();

            AddressBook add = new AddressBook();
            Person person = new Person();
            person.First_Name = "PRAFUL";
            person.Last_Name = "RAKHADE";
            person.Address = "WARD NO.2 NEAR RAJESH MEDICAL KHAT";
            person.City = "NAGPUR";
            person.State = "MAHARASHTRA";
            person.Zip_Code = 441106;
            person.Phone_Number = 7038008002;
            person.Email_ID = "prafulrakhade02@gmail.com";
            add.AddPerson(person);
            add.Display();
            Console.WriteLine("=================================================================================");


            AddressBook manage = new();
            Person per = new Person();
            Console.WriteLine("=====USER INPUT=======");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            per.First_Name = firstName;
            Console.WriteLine();
            Console.Write("Enter the last Name: ");
            string lastName = Console.ReadLine();
            per.Last_Name = lastName;
            Console.WriteLine();
            Console.Write("Enter the Address: ");
            string address = Console.ReadLine();
            per.Address = address;
            Console.WriteLine();
            Console.Write("Enter the City: ");
            string city = Console.ReadLine();
            per.City = city;
            Console.WriteLine();
            Console.Write("Enter the State: ");
            string state = Console.ReadLine();
            per.State = state;
            Console.WriteLine();
            Console.Write("Enter the Zip Code: ");
            long zipCode = long.Parse(Console.ReadLine());
            per.Zip_Code = zipCode;
            Console.WriteLine();
            Console.Write("Enter the Phone Number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            per.Phone_Number = phoneNumber;
            Console.WriteLine();
            Console.Write("Enter the Email ID: ");
            string email = Console.ReadLine();
            per.Email_ID = email;
            Console.WriteLine();
            manage.Display();
            manage.AddPerson(per);
            Console.WriteLine("============================================================");


            AddressBook edit = new();
            edit.Display();
            Console.WriteLine("Enter The Name For Edit Contact Details: ");
            Console.WriteLine();
            string Name1 = Console.ReadLine();
            edit.EditPersonDetails(Name1);
            edit.Display();
            Console.WriteLine("============================================================");


            AddressBook delete = new AddressBook();
            delete.Display();
            Console.WriteLine("Enter The Name For Delete the Contact Details: ");
            string Name2 = Console.ReadLine();
            delete.RemovePersonDetails(Name2);
            delete.Display();
            Console.WriteLine("============================================================");
        }
    }
}
