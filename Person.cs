using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    internal class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public long Zip_Code;
        public long Phone_Number;
        public string Email_ID;

        public string Result()
        {
            return "First Name: " + First_Name + "\n Last name: " + Last_Name + "\n Address: " + Address + "\n City: " + City +
            "\n State:" + State + "\n Zop COde: " + Zip_Code + "\n Phone Number: " + Phone_Number + "/n Email ID: " + Email_ID;
        }
    }

    internal class AddressBook
    {

        public List<Person> person = new List<Person>();

        public void Display()
        {
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void AddPerson(Person p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"C:\Users\HP\BridgeLabzs\Assignment\Day-10\AddressBookSystem\AddressBookSystem\AddressBookResult.json", jsonData);
        }
        public AddressBook()
        {
            string json = File.ReadAllText(@"C:\Users\HP\BridgeLabzs\Assignment\Day-10\AddressBookSystem\AddressBookSystem\AddressBookResult.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
            {
                person = new List<Person>();
            }
        }
        public void EditPersonDetails(string First_Name)
        {
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].First_Name == First_Name)
                {
                    Console.WriteLine("Enter The First Name: ");
                    person[i].First_Name = Console.ReadLine();
                    Console.WriteLine("Enter The Last Name: ");
                    person[i].Last_Name = Console.ReadLine();
                    Console.WriteLine("Enter The Address ");
                    person[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter The City: ");
                    person[i].City = Console.ReadLine();
                    Console.WriteLine("Enter The State: ");
                    person[i].State = Console.ReadLine();
                    Console.WriteLine("Enter The Zip Code: ");
                    person[i].Zip_Code = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Phone Number: ");
                    person[i].Phone_Number = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Email ID: ");
                    person[i].Email_ID = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Only Same Name Required ");
                }
            }
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"C:\Users\HP\BridgeLabzs\Assignment\Day-10\AddressBookSystem\AddressBookSystem\AddressBookResult.json", jsonData);
        }

        public void RemovePersonDetails(string First_Name)
        {
            Person persn = null;
            foreach (Person del in person)
            {
                if (del.First_Name == First_Name)
                {
                    persn = del;
                }
            }
            person.Remove(persn);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json", jsonData);
        }
    }

}