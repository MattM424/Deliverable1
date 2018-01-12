using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            var strNum1 = Console.ReadLine();
            int num1;
            bool num1Parsed = int.TryParse(strNum1, out num1);
            if (!num1Parsed)
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            bool doTheNumbersMatch = DoNumbersMatch(num1, num2);

            Console.WriteLine(doTheNumbersMatch ? "Those numbers match" : "Those numbers do not match");
        }

        private static bool DoNumbersMatch(int num1, int num2)
        {
            var num1ToArray = num1.ToString().ToCharArray();
            var num2ToArray = num2.ToString().ToCharArray();

            if (num1ToArray.Length != num2ToArray.Length)
            {
                return false;
            }

            int answer = 0;
            for (var i = 0; i < num1ToArray.Length && i < num2ToArray.Length; i++)
            {
                var firstNum = int.Parse(num1ToArray[i].ToString());
                var secondNum = int.Parse(num2ToArray[i].ToString());

                if (i == 0)
                {
                    answer = firstNum + secondNum;
                    continue;
                }

                if (answer != (firstNum + secondNum))
                {
                    return false;
                }
            }

            return true;
        }   
        
    }   

}
