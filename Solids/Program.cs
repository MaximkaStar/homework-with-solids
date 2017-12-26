using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solids
{
    class Program
    {
        public static int FirstThreeNumbersEquals { get; private set; }
        public static int SecondThreeNumbersEquals { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("First target...");
            Console.Write("Please, write a somebody text...");
            string strng = Console.ReadLine();
            int pointPosition = strng.IndexOf(".");

            int nmbrfspces = 0;
            if (pointPosition != 1)
            {
                for (int m = 0; m < pointPosition; m++)
                {
                    if (strng[m] == ' ')
                    {
                        nmbrfspces++;
                    }
                }
            }

            Console.Write("Count of spaces before first point:");
            Console.WriteLine(nmbrfspces);
            Console.ReadLine();
            Console.Clear();

            Console.Write("Second target...");
            Console.Write("Please, write a ticket number: ");
            int numeric;
            bool isParsed = int.TryParse(Console.ReadLine(), out numeric);
            if (isParsed)
            {
                if (numeric >= 0 && numeric <= 9)
                {
                    if (numeric < 3)
                    {

                        FirstThreeNumbersEquals += numeric;
                    }
                    else
                    {
                        SecondThreeNumbersEquals += numeric;
                    }
                    numeric++;
                }
                else
                {
                    Console.WriteLine("Error. Maybe you write a wrong number. Try Again...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Error. Maybe you write a wrong number. Try Again...");
                Console.ReadLine();
            }
            Console.Clear();

            if (FirstThreeNumbersEquals == SecondThreeNumbersEquals)
            {
                Console.WriteLine("YES! Your ticket is lucky.");
            }
            else
            {
                Console.WriteLine("OH NO! Your ticket is unlucky.(");
            }

            Console.Write("Third target...");
            Console.WriteLine("Please, write a smbd text:");
            string strg = Console.ReadLine();

            StringBuilder builderMan = new StringBuilder();
            foreach (char m in strg)
            {
                builderMan.Append(ToUp(m));
            }
            strg = builderMan.ToString();
            Console.Write("String only in uppest register.");
            Console.WriteLine(strg);
            builderMan.Clear();

            Console.WriteLine("Please, write a smbd text: ");
            strg = Console.ReadLine();
            foreach (char m in strg)
            {
                builderMan.Append(ToLow(m));
            }
            strg = builderMan.ToString();
            Console.Write("String only in lowest register.");
            Console.WriteLine(strg);

            Console.Write("Fourth target...");
            Console.WriteLine("Please, write a first number...");
            int numericFirst;
            int numericSecond;
            bool isparsed = int.TryParse(Console.ReadLine(), out numericFirst);
            while (!isparsed)
            {
                Console.Write("Error. Please, try again...");
                isparsed = int.TryParse(Console.ReadLine(), out numericFirst);
                Console.Clear();
            }

            Console.WriteLine("Please, write a second number...");
            isparsed = int.TryParse(Console.ReadLine(), out numericSecond);
            while (!isparsed)
            {
                Console.Write("Error. Please, try again...");
                isparsed = int.TryParse(Console.ReadLine(), out numericSecond);
                Console.Clear();
            }

            for (int m = numericFirst; m <= numericSecond; m++)
            {
                for (int n = 0; n < m; n++)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
                Console.Clear();
            }

            Console.Write("Fifth target...");
            const int Ten = 10;
            int tale;
            bool p4rsed = int.TryParse(Console.ReadLine(), out tale);
            while (!p4rsed)
            {
                Console.Write("Error. Please, try again... ");
                p4rsed = int.TryParse(Console.ReadLine(), out tale);
                Console.Clear();
            }
            int TaleRank = tale.ToString().Length;
            int[] TaleSolid = new int[TaleRank];
            for (int m = 0; m < TaleRank; m++)
            {
                TaleSolid[m] = tale / Ten;
            }
            Console.Write("Inverted number is: ");
            foreach (int m in TaleSolid)
            {
                Console.Write(m);
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static char ToLow(char m)
        {
            throw new NotImplementedException();
        }
        private static char ToUp(char m)
        {
            throw new NotImplementedException();
        }
    }
}

