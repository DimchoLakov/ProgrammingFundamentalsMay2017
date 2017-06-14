using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long numbersOfId = long.Parse(Console.ReadLine());
            long maxValue = 0L ;
            switch (numeralType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }
            long thiefsId = long.MinValue;

            for (int i = 0; i < numbersOfId; i++)
            {
                long eachId = long.Parse(Console.ReadLine());
                if (eachId > thiefsId && eachId <= maxValue)
                {
                    thiefsId = eachId;
                }
            }
            Console.WriteLine(thiefsId);
        }
    }
}
