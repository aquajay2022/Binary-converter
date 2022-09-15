using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Binary converter
            Console.ForegroundColor = ConsoleColor.DarkGreen;  
            Console.WriteLine("Welcome to the binary coverter");
            Console.Write("Would you like to convert to binary or from binary? ");
            string menuchoice = Console.ReadLine();

            //Converts any number to binary
            if (menuchoice == "to")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Enter a number: ");
                string number = Console.ReadLine();
                int numberout = 0;
                Int32.TryParse(number, out numberout);
                string binaryconv = Convert.ToString(numberout, 2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(binaryconv);
            }

            //Converts from binary to a base 10 number
            if (menuchoice == "from")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Binary: ");
                string s = Console.ReadLine();
                int dec = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[s.Length - i - 1] == '0') continue;
                    dec += (int)Math.Pow(2, i);
                }
                Console.WriteLine(dec);
                Console.ReadKey();
            }
        }
    }
}
