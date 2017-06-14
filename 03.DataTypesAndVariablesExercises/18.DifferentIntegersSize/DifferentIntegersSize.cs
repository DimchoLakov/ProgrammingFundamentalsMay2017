using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string dataTypes = null;
            int overflow = 0;
            string input = Console.ReadLine();
            try
            {
                sbyte number = sbyte.Parse(input);
                dataTypes += "* sbyte\n";
            }
            catch (OverflowException)
            {
                
            }
            try
            {
                byte number = byte.Parse(input);
                dataTypes += "* byte\n";
            }
            catch (OverflowException)
            {
                
            }
            try
            {
                short number = short.Parse(input);
                dataTypes += "* short\n";
            }
            catch (OverflowException)
            {

            }
            try
            {
                ushort number = ushort.Parse(input);
                dataTypes += "* ushort\n";
            }
            catch (OverflowException)
            {

            }
            try
            {
                int number = int.Parse(input);
                dataTypes += "* int\n";
            }
            catch (OverflowException)
            {

            }
            try
            {
                uint number = uint.Parse(input);
                dataTypes += "* uint\n";
            }
            catch (OverflowException)
            {

            }
            try
            {
                long number = long.Parse(input);
                dataTypes += "* long\n";
            }
            catch (OverflowException)
            {
                overflow++;
                Console.WriteLine($"{input} can't fit in any type");
            }
            if (overflow == 0)
            {
                Console.WriteLine($"{input} can fit in:\n{dataTypes}");
            }
        }
    }
}
