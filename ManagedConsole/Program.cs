using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            cppWrapper.cppWrapperClass cwc = new cppWrapper.cppWrapperClass();

            string userinput;
            int userval1 = int.MinValue,
                userval2 = int.MinValue;

            Console.WriteLine("C++ wrapper example\r\n");
            while(true)
            {
                Console.WriteLine("Enter number");
                try
                {
                    userinput = Console.ReadLine();
                    if (userval1 == int.MinValue)
                        userval1 = int.Parse(userinput);
                    else
                        userval2 = int.Parse(userinput);
                }
                catch
                {
                    Console.WriteLine("invalid numeric intput, please try again!");
                }
                if (userval1 != int.MinValue && userval2 != int.MinValue)
                    break;
            }
            Console.WriteLine(string.Format("Sum of both number is: {0}", cwc.cppWrapperAddMethod(userval1,userval2)));
            Console.WriteLine("\r\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
