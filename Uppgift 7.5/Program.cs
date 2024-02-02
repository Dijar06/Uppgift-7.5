using System;
using System.Collections.Generic;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lön = new List<int>();
            Console.WriteLine("Skriv dina senaste månadslöner, avsluta med \"0\"");
            int nylön = 1;
            while (nylön != 0)
            {
                Console.WriteLine("Skriv ny lön:");
                nylön = int.Parse(Console.ReadLine());
                if (nylön != 0)
                {
                    lön.Add(nylön);
                }
            }
            Console.WriteLine("Här är medellönen:");
            int sum = 0;

            foreach (int element in lön)
            {
                sum += element;
            }
            double medellön = (double)sum / lön.Count;
            Console.WriteLine(medellön);

            Console.WriteLine("Här är medianlönen:");
            lön.Sort();
            int mittenIndex = lön.Count / 2;

            if (lön.Count % 2 == 0)
            {
                int mittenLön1 = lön[mittenIndex - 1];
                int mittenLön2 = lön[mittenIndex];
                double medianlön = (double)(mittenLön1 + mittenLön2) / 2;
                Console.WriteLine(medianlön);
            }
            else
            {
                int medianlön = lön[mittenIndex];
                Console.WriteLine(medianlön);
            }
        }
    }
}