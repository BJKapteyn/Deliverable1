using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery1
{
    class PrintMoney
    {
        //adds the decimal and comma delimiter for swedish money notation
        public static string SwedishNotation(double num)
        {
            char[] numberArray = Math.Round(num, 2).ToString().ToCharArray();
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
            char[] numberArray = Math.Round(num, 2).ToString().ToCharArray();
            string notationNumber = "";
            int count = 3;
            for(int i = 0; i < numberArray.Length; i++)
            {
                if (i == 0)
                {
                    count = (numberArray.Length - 3) % 3;
                }
                if (numberArray[i].ToString() == ".")
                {
                    count = 3;
                }
                else if(count == 0)
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

        private static string OrganizePrint(string money, string country)
        {

        }

        public static string ToUS(double num)
        {
            return "$" + MoneyNotation(num);
        }
        
        public static string ToSEK(double num)
        {
            return SwedishNotation(num) + "kr";
        }

        public static string ToJapanese(double num)
        {
            return "\u00A5" + MoneyNotation(Math.Round(num, 0));
        }

        public static string ToThai(double num)
        {
            return "\u0E3F" + MoneyNotation(num);
        }

        public void PrintConversion(string us, string sek, string jap, string thai)
        {

        }
    }
}
