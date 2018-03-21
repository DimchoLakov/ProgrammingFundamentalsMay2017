using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> affectedSites = new List<string>();
            decimal siteLoss = 0;

            int n = int.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string siteName = tokens[0];
                long siteVisits = long.Parse(tokens[1]);
                decimal pricePerVisit = decimal.Parse(tokens[2]);

                siteLoss += siteVisits * pricePerVisit;

                affectedSites.Add(siteName);
            }

            affectedSites.Distinct();

            int affectedSitesCount = affectedSites.Count;

            BigInteger securityToken = BigInteger.Pow(securityKey, affectedSitesCount);

            PrintOutPut(affectedSites, siteLoss, securityToken);
        }

        static void PrintOutPut(List<string> affectedSites, decimal siteLoss, BigInteger securityToken)
        {
            foreach (string affectedSite in affectedSites)
            {
                Console.WriteLine(affectedSite);
            }

            Console.WriteLine($"Total Loss: {siteLoss:f20}");

            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
