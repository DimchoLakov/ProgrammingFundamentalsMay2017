using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skipTakeElements = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int skip = skipTakeElements[0];
            int take = skipTakeElements[1];

            string input = Console.ReadLine();

            List<string> result = new List<string>();
            
            string cameraPattern = @"(?<=(\|\<))\w+";
            Regex camRegex = new Regex(cameraPattern);

            MatchCollection matches = camRegex.Matches(input);

            foreach (Match match in matches)
            {
                string camera = new string(match.Value.Skip(skip).Take(take).ToArray());
                if (! string.IsNullOrEmpty(camera))
                {
                    result.Add(camera);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
