using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.DebugInstructionSet
{
    class DebugInstructionSet
    {
        static void Main(string[] args)
        {           

            while (true)
            {
                string operation = Console.ReadLine();
                string[] arrayString = operation.Split(' ');

                BigInteger result = 0;
                switch (arrayString[0])
                {
                    case "INC":
                        {
                            BigInteger operandOne = BigInteger.Parse(arrayString[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            BigInteger operandOne = BigInteger.Parse(arrayString[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            BigInteger operandOne = BigInteger.Parse(arrayString[1]);
                            BigInteger operandTwo = BigInteger.Parse(arrayString[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            BigInteger operandOne = BigInteger.Parse(arrayString[1]);
                            BigInteger operandTwo = BigInteger.Parse(arrayString[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                    case "END":
                        return;
                }
                Console.WriteLine($"{result}");
            }
        }
    }
}
