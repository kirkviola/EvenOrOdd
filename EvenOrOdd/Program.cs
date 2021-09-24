using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EvenOrOdd();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("I said an integer dummy.");
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Not quite that big of a number.");
            }
        }
        static void EvenOrOdd()
        {
            Console.Write("Please enter an integer: ");
            var TestStr = Console.ReadLine();
            var TestNum = Convert.ToInt32(TestStr);
            if (TestNum % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
