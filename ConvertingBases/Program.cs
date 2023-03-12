using System;

namespace ChangingBases
{
    class ChangingBases
    {
        // ValueToChar method returns ASCII char for a value
        // In ASCII table 0 starts from 48, so by adding 48 we will get corresponding ASCII character ('2' for 2 and etc.)
        // If number is greater than 10, then we should subtract 10 and add 65
        // So number 11 will be converted into ASCII char 'B', the number 13 into char 'D' and etc.

        static char ValueToChar(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + 48);
            else
                return (char)(num - 10 + 65);   
        }

        static string FromDecimToBase(int newBase, int inputNum)
        {
            // If user entered a negative number, we should convert it into positive so we can make calculations
            // After all calculations we add '-' to the result

            int inputNumPositive;

            if (inputNum < 0)
                inputNumPositive = inputNum * -1;
            else
                inputNumPositive = inputNum;

            string s = "";

            while (inputNumPositive > 0)
            {
                s += ValueToChar(inputNumPositive % newBase);
                inputNumPositive /= newBase;
            }

            // We cannot reverse the string s directly, so we have to convert it into an array

            char[] res = s.ToCharArray();
            Array.Reverse(res);
            string result = new String(res);
            if (inputNum < 0)
            {
                result = result.Insert(0, "-");
                return result;
            }
            else
                return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("This program converts a number with base 10 into a number with any base (from 2 to 20).\n\n" +
                "Type a number which you want to convert and press Enter:");

            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum == 0)
                Console.WriteLine("You entered 0 number, so the result of converting it into any other base system would be also 0");

            Console.WriteLine("Type a base you want to convert your number into:");
            int newBase = int.Parse(Console.ReadLine());

            if (newBase < 2 || newBase > 20)
            {
                Console.WriteLine($"Just a little reminder that the final base should be from 2 to 20. You chose the base outside of this scope - {newBase}. Please type another base:");
                newBase = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Equivalent of " + inputNum + " in base " + newBase + " is " + FromDecimToBase(newBase, inputNum));

            Console.ReadKey();
        }
    }
}