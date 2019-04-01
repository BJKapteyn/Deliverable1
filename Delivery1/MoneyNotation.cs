using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery1
{
    class PrintMoney
    {
        //I know there are easier ways to do this but I had extra time and wanted to see if I could do it myself
        //adds the decimal and comma delimiter for swedish money notation
        public static string SwedishNotation(double num)
        {
            char[] numberArray = Math.Round(num, 2)
                                 .ToString()
                                 .ToCharArray();
            string notationNumber = "";
            int count = 3;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i == 0)
                {
                    count = (numberArray.Length - 3) % 3;
                }
                if (numberArray[i].ToString() == ".")
                {
                    notationNumber += ",";
                    count = 3;
                    continue;
                }
                else if (count == 0 && i == 0)
                {
                    notationNumber += numberArray[i];
                    count = 3;
                    continue;
                }
                else if (count == 0)
                {
                    notationNumber += ".";
                    i--;
                    count = 3;
                    continue;
                }
                count--;
                notationNumber += numberArray[i];
            }
            return notationNumber;
        }
        //adds comma delimiter for US and Thai money numbers
        public static string MoneyNotation(double num)
        {
            char[] numberArray = Math.Round(num, 2)
                                 .ToString()
                                 .ToCharArray();
            string notationNumber = "";
            int count = 3;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i == 0)
                {
                    count = (numberArray.Length - 3) % 3;
                }
                if (numberArray[i].ToString() == ".")
                {
                    count = 3;
                }
                else if(count == 0 && i == 0)
                {
                    notationNumber += numberArray[i];
                    count = 3;
                    continue;
                }
                else if (count == 0)
                {
                    notationNumber += ",";
                    i--;
                    count = 3;
                    continue;
                }
                count--;
                notationNumber += numberArray[i];
            }
            return notationNumber;
        }
        //adds spaces to be more legable 
        public static string OrganizePrint(string country, string money)
        {
            int cSpaces = 20 - country.Length;
            int mSpaces = 20 - money.Length;
            string cSpace = "";
            string mSpace = "";

            for (int i = 0; i < cSpaces; i++)
            {
                cSpace += " ";
            }
            for (int i = 0; i < mSpaces; i++)
            {
                mSpace += " ";
            }

            return country + cSpace + mSpace + money;
        }

        public static string ToUS(double num)
        {
            return "$ " + MoneyNotation(num);
        }

        public static string ToSEK(double num)
        {
            return SwedishNotation(num) + " kr";
        }

        public static string ToJapanese(double num)
        {
            return "\u00A5 " + MoneyNotation(Math.Round(num, 0));
        }

        public static string ToThai(double num)
        {
            return /*"\u0E3F" not working for some reason*/"B " + MoneyNotation(num);
        }
        //print everything 
        public static void PrintNotation(string us, string sek, string jap, string thai, double num)
        {
            Console.WriteLine(OrganizePrint(us, ToUS(num)));
            Console.WriteLine(OrganizePrint(sek, ToSEK(num)));
            Console.WriteLine(OrganizePrint(jap, ToJapanese(num)));
            Console.WriteLine(OrganizePrint(thai, ToThai(num)));
        }
    }
}
