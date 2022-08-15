using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {

                Console.WriteLine(@"
enter the number for the function you want
1. convert roman to number
2. numbers to roman 
3. exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a number to convert to roman numerals");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(ConvertToRoman(number));
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("Enter a roman numeral");
                        string roman = Console.ReadLine().ToUpper();
                        int numbers = 0;
                        int previous = 0;
                        foreach (char c in roman)
                        {
                            int current = RomanToNumber(c);
                            if (current > previous)
                                numbers -= previous;
                            else
                                numbers += previous;
                            previous = current;
                        }
                        numbers += previous;
                        Console.WriteLine(numbers);
                        Console.ReadLine();
                        break;
                    case 3:
                        //exit app
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
           
        }
        #region functions
        // on a char base convert the roman numeral into a numeric value
        private static int RomanToNumber(char c)
        {
           
            if (c == 'I')
                return 1;
            else if (c == 'V')
                return 5;
            else if (c == 'X')
                return 10;
            else if (c == 'L')
                return 50;
            else if (c == 'C')
                return 100;
            else if (c == 'D')
                return 500;
            else if (c == 'M')
                return 1000;
            else
                return 0;
        }
        private static string ConvertToRoman(int number)
        {
            string romanNumeral = "";
            while (number > 0)
            {
                if (number >= 1000)
                {
                    romanNumeral += "M";
                    number -= 1000;
                }
                else if (number >= 900)
                {
                    romanNumeral += "CM";
                    number -= 900;
                }
                else if (number >= 500)
                {
                    romanNumeral += "D";
                    number -= 500;
                }
                else if (number >= 400)
                {
                    romanNumeral += "CD";
                    number -= 400;
                }
                else if (number >= 100)
                {
                    romanNumeral += "C";
                    number -= 100;
                }
                else if (number >= 90)
                {
                    romanNumeral += "XC";
                    number -= 90;
                }
                else if (number >= 50)
                {
                    romanNumeral += "L";
                    number -= 50;
                }
                else if (number >= 40)
                {
                    romanNumeral += "XL";
                    number -= 40;
                }
                else if (number >= 10)
                {
                    romanNumeral += "X";
                    number -= 10;
                }
                else if (number >= 9)
                {
                    romanNumeral += "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumeral += "V";
                    number -= 5;
                }
                else if (number >= 4)
                {
                    romanNumeral += "IV";
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanNumeral += "I";
                    number -= 1;
                }
            }
            return romanNumeral;
        }
    }
        #endregion
}

