using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                string command = input[0];

                switch (command)
                {
                    case "A":

                        string name = input[1];
                        string phoneNUmber = input[2];

                        phonebook[name] = phoneNUmber;

                        break;

                    case "S":

                        string searchName = input[1];


                        if (phonebook.ContainsKey(searchName))
                        {
                            Console.WriteLine($"{searchName} -> {phonebook[searchName]} ");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {searchName} does not exist.");
                        }

                        break;
                    case "ListAll":

                        var sortedPhonebook = new SortedDictionary<string, string>(phonebook);
                        foreach (var contact in sortedPhonebook)
                        {
                            Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        }

                        //foreach (var contact in phonebook.OrderBy(key => key.Key))
                        //{
                        //    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        //}


                        break;
                    case "END":
                        return;
                }
            }
        }
    }
}
