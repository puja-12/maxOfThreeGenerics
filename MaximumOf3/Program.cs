// See https://aka.ms/new-console-template for more information
using System;
namespace maxOfThree
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum of Three using generics!");

            Console.WriteLine("Please enter the values of integers x, y and z:");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            usingInt usingInt = new usingInt();
            int result = usingInt.Maximum(x, y, z);
            Console.WriteLine("The Maximum of three integers is :" + result);
        }
    }
}