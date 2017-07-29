using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                if (command == "register")
                {
                    string username = tokens[1];
                    string licensePlateNumber = tokens[2];

                    int licensePlateNumberLength = licensePlateNumber.Length;
                    List<char> firstTwoChars = licensePlateNumber.Take(2).ToList();
                    List<char> lastTwoChars = licensePlateNumber.Reverse().Take(2).ToList();
                    List<char> middleFourNumbers = licensePlateNumber.Skip(2).Take(4).ToList();

                    bool areFirstTwoValid = CheckChars(firstTwoChars);
                    bool areLastTwoValid = CheckChars(lastTwoChars);
                    bool areMiddleDigits = CheckDigits(middleFourNumbers);


                    if (licensePlateNumberLength == 8 && areMiddleDigits && areFirstTwoValid && areLastTwoValid)
                    {
                        if (!parkingDatabase.ContainsKey(username) && !parkingDatabase.ContainsValue(licensePlateNumber))
                        {
                            parkingDatabase.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else if (!parkingDatabase.ContainsKey(username) && parkingDatabase.ContainsValue(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                        }
                    }
                    else if (parkingDatabase.ContainsKey(username) &&
                             !parkingDatabase.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string username = tokens[1];

                    if (!parkingDatabase.ContainsKey(username))
                    {
                        Console.WriteLine($"ËRROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        parkingDatabase.Remove(username);
                    }
                }
            }

            foreach (KeyValuePair<string, string> usernameLicensePlate in parkingDatabase)
            {
                Console.WriteLine($"{usernameLicensePlate.Key} => {usernameLicensePlate.Value}");
            }

        }

        static bool CheckDigits(List<char> digits)
        {
            for (int j = 0; j < digits.Count; j++)
            {
                if (!char.IsDigit(digits[j]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckChars(List<char> charsList)
        {
            for (int j = 0; j < charsList.Count; j++)
            {
                if (!char.IsLetter(charsList[j]) || !char.IsUpper(charsList[j]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
