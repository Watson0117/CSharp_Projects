﻿using System;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick 2 numbers the first is will have 10 added to it and then it will display the second below that");
            string UserInput1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(UserInput1);

            string UserInput2 = Console.ReadLine();


            Class1 Class1 = new Class1();
            try
            {
                int Num2 = Convert.ToInt32(UserInput2);
                int TwoEntry = Class1.Method1(Num1);// this line calls the method 
                Console.WriteLine(TwoEntry);
                Console.WriteLine(Num2);
            }

            catch
            {
                Console.WriteLine("There seems to be an error");
            }
        }
    }
}
