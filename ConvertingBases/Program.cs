using System;

namespace ChangingBases
{
    class ChangingBases
    {
        static char ValueToChar(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + 48);
            else
                return (char)(num - 10 + 65);
        }

        static string fromDecimToBase(int newBase, int inputNum)
        {
            string s = "";

            while (inputNum > 0)
            {
                s += ValueToChar(inputNum % newBase);
                inputNum /= newBase;
            }
            char[] res = s.ToCharArray();

            Array.Reverse(res);
            return new String(res);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts a number with base 10 into a number with any base.\n\n" +
                "Type a number which you want to convert and press Enter:");

            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a base you want to convert your number into:");
            int newBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Equivalent of " + inputNum + " in base " + newBase + " is " + fromDecimToBase(newBase, inputNum));

            Console.ReadKey();
        }
    }
}