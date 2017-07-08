using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().ToLower().Split(new Char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '},StringSplitOptions.RemoveEmptyEntries);

            var result = textArr.Where(x => x.Length < 5).OrderBy(x => x).ToList().Distinct();
          
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
