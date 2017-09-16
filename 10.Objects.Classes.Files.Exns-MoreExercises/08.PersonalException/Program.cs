using System;

namespace _08.PersonalException
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base($"My first exception is awesome!!!")
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number >= 0)
                    {
                        Console.WriteLine(number);
                    }
                    else
                    {
                        throw new NegativeNumberException();
                    }
                }
            }
            catch (NegativeNumberException myExcp)
            {
                Console.WriteLine(myExcp.Message);
            }
        }
    }
}
