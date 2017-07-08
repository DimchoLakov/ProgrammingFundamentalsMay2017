using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var emailBook = new Dictionary<string, string>();

            string name = Console.ReadLine();
            if (name == "stop")
            {
                return;
            }
            string email = Console.ReadLine();

            while (true)
            {

                if (emailBook.ContainsKey(name))
                {
                    emailBook[name] = email;
                }
                else
                {
                    emailBook.Add(name, email);
                }

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    emailBook.Remove(name);
                }
                name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                email = Console.ReadLine();
            }

            foreach (var contact in emailBook)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
