using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeighLanguages
{
    class ForeighLanguages
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();
            string language = null;
            switch (country)
            {
                case "usa":
                case "england":
                    language = "English";
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }
            Console.WriteLine(language);
        }
    }
}
