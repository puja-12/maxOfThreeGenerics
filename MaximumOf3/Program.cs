// See https://aka.ms/new-console-template for more information
using System;
namespace maxOfThree
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum of Three using generics!");

            while (true)
            {

                Console.WriteLine("Choose the Program to be executed :\n1)using INT\n2)using Float\n3)using String\n4)genericsMethodfor3Datatypes\n5)generic class and Method\n6)max using array\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter the values of integers x, y and z:");
                        int x = Convert.ToInt16(Console.ReadLine());
                        int y = Convert.ToInt16(Console.ReadLine());
                        int z = Convert.ToInt16(Console.ReadLine());
                        usingInt usingInt = new usingInt();
                        int result = usingInt.Maximum(x, y, z);
                        Console.WriteLine("The Maximum of three integers is :" + result);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the values of floats a, b and c:");
                        double a = Convert.ToInt16(Console.ReadLine());
                        double b = Convert.ToInt16(Console.ReadLine());
                        double c = Convert.ToInt16(Console.ReadLine());
                        usingfloat Usingfloat = new usingfloat();
                        double result1 = Usingfloat.Maximumfloat(a, b, c);
                        Console.WriteLine("The Maximum of three integers is :" + result1);
                        break;
                    case 3:
                        Console.WriteLine("Please enter the values of Strings first, second and thirdString");
                        string e = Convert.ToString(Console.ReadLine());
                        string f = Convert.ToString(Console.ReadLine());
                        string g = Convert.ToString(Console.ReadLine());
                        usingstring usingstrings = new usingstring();
                        string result2 = usingstrings.Maximum(e, f, g);
                        Console.WriteLine("The Maximum of three strings is :" + result2);
                        break;
                    case4:
                        GenericClass genericClass = new GenericClass();
                        int value1 = GenericClass.Maximum<int>(4, 6, 8);
                        Console.WriteLine("The Maximum of three integers is :" + value1);
                        double value2 = GenericClass.Maximum<double>(1.1, 2.3, 3.4);
                        Console.WriteLine("The Maximum of three values is :" + value2);
                        string value3 = GenericClass.Maximum<string>("wheat", "rice", "pilses");
                        Console.WriteLine("The Maximum of three strings is :" + value3);
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        int G1 = GenericMethod<int>.MaxusingGenerics<int>(2, 3, 4);
                        Console.WriteLine("The Maximum of three integers is :" + G1);
                        double G2 = GenericMethod<double>.MaxusingGenerics<double>(2.2, 3.3, 4.4);
                        Console.WriteLine("The Maximum of three values is :" + G2);
                        string G3 = GenericMethod<string>.MaxusingGenerics<string>("Wheat", "Rice", "pulse");
                        Console.WriteLine("The Maximum of three strings is :" + G3);
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        int[] intarray = { 1, 2, 3, 4, 5, 6, 7 };
                        double[] doublearray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                        string[] stringarray = { "wheat", "Rice", "pulse" };
                        int A1 = maxMethodusingArray.IntArray(intarray);
                        Console.WriteLine("The Maximum of IntArray is :" + A1);
                        double A2 = maxMethodusingArray.DoubleArray(doublearray);
                        Console.WriteLine("The Maximum of DoubleArray is :" + A2);
                        string A3 = maxMethodusingArray.StringArray(stringarray);
                        Console.WriteLine("The Maximum of StringArray is :" + A3);
                        Console.WriteLine("\n");
                        break;

                  

                }
            }
        }
    }
}
    
