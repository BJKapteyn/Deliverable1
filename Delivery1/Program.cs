using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery1
{
    class Program
    {
        static void Main(string[] args)
        {
            string function()
            {
                double number1, number2, number3;
                double low = 0;
                double high = 0;

                //finds low and high number and assigns it to variables low and high.
                void lowHigh(double[] numArray)
                {
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        if(i == 0)
                        {
                            if (numArray[0] > numArray[1])
                            {
                                high = numArray[0];
                                i++;
                            }
                            else
                            {
                                high = numArray[1];
                                i++;
                            }
                            continue;
                        }
                        else if (numArray[i] >= high)
                        {
                            high = numArray[i];
                        }
                    }
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        if (i == 0)
                        {
                            if (numArray[0] < numArray[1])
                            {
                                low = numArray[0];
                                i++;
                            }
                            else
                            {
                                low = numArray[1];
                                i++;
                            }
                            continue;
                        }
                        if (numArray[i] <= low)
                        {
                            low = numArray[i];
                        }
                    }
                }

                //next three while loops get the three numbers, checks if they're positive numbers, and assigns them to number variables.
                Console.WriteLine("Enter three numbers to get the low, high, average, and total written out as money from different " +
                    "countries. \nPress Q to quit\n");
                while (true)
                {
                    Console.Write("Enter first number: ");
                    string num1 = Console.ReadLine();
                    string qNum = num1.ToUpper();
                    var isNumber = double.TryParse(num1, out double x);

                    if (qNum == "Q")
                    {
                        return " ";
                    }
                    else if (!isNumber || Convert.ToDouble(num1) < 0)
                    {
                        Console.WriteLine("Please enter a positive number.");
                        continue;
                    }
                    else
                    {
                        number1 = Convert.ToDouble(num1);
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Enter second number: ");
                    string num = Console.ReadLine();
                    string qNum = num.ToUpper();
                    var isNumber = double.TryParse(num, out double x);

                    if (qNum == "Q")
                    {
                        return " ";
                    }
                    else if (!isNumber || Convert.ToDouble(num) < 0)
                    {
                        Console.WriteLine("Please enter a positive number.");
                        continue;
                    }
                    else
                    {
                        number2 = Convert.ToDouble(num);
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Enter third number: ");
                    string num1 = Console.ReadLine();
                    string qNum = num1.ToUpper();
                    var isNumber = double.TryParse(num1, out double x);

                    if (qNum == "Q")
                    {
                        return " ";
                    }
                    else if (!isNumber || Convert.ToDouble(num1) < 0)
                    {
                        Console.WriteLine("Please enter a positive number.");
                        continue;
                    }
                    else
                    {
                        number3 = Convert.ToDouble(num1);
                        break;
                    }
                }

                double[] numberArray = new double[3] { number1, number2, number3 };
                lowHigh(numberArray);
                double average = Math.Round((number1 + number2 + number3) / 3, 2);
                double total = Math.Round(number1 + number2 + number3);


                //prints the results
                Console.WriteLine($"The lowest number is {low}, the highest is {high}, and the average is {average}\n");
                Console.WriteLine("Here it is the total in money notations of different countries:\n");
                PrintMoney.PrintNotation("United States", "Sweden", "Japan", "Taiwan", total);

                //restart program of exit
                Console.Write("\n\"R\" to restart program or any other key to exit: ");
                string restart = Console.ReadLine().ToUpper();
                if(restart == "R")
                {
                    Console.Clear();
                    function();
                }
                else
                {
                    return " ";
                }
                return " ";
            }
            function();

        }

    }
}
