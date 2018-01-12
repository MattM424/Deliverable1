using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gets first number
            Console.Write("Enter the first number: ");
            var strNum1 = Console.ReadLine();
            int num1;
            bool num1Parsed = int.TryParse(strNum1, out num1);
            if (!num1Parsed)
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            //gets second number
            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid Number");
                return;
            }


            bool doTheNumbersMatch = DoNumbersMatch(num1, num2);

            //writes out answer
            Console.WriteLine(doTheNumbersMatch ? "Those numbers match" : "Those numbers do not match");
            Console.ReadKey();
        }

        private static bool DoNumbersMatch(int num1, int num2)
        {
            //converts numbers to array
            var num1ToArray = num1.ToString().ToCharArray();
            var num2ToArray = num2.ToString().ToCharArray();

            //tests if numbers are the same length
            if (num1ToArray.Length != num2ToArray.Length)
            {
                return false;
            }

            //sets the index for the array
            int answer = 0;
            for (var i = 0; i < num1ToArray.Length && i < num2ToArray.Length; i++)
            {
                var firstNum = int.Parse(num1ToArray[i].ToString());
                var secondNum = int.Parse(num2ToArray[i].ToString());

                //tests first set of numbers
                if (i == 0)
                {
                    answer = firstNum + secondNum;
                    continue;
                }

                //test remaining numbers against the first set of number
                if (answer != (firstNum + secondNum))
                {
                    return false;
                }
            }

            return true;
        }   
        
    }   

}
