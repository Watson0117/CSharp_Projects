﻿using System;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick 2 numbers the first is requiered and the secod optional");
            string UserInput1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(UserInput1);

            string UserInput2 = Console.ReadLine();
            

            Class1 Class1 = new Class1();
            try
            {
                int Num2 = Convert.ToInt32(UserInput2);
                int TwoEntry = Class1.Method1(Num1, Num2);// this line calls the method 
                Console.WriteLine(TwoEntry);
            }
            
            catch
            {
               
                int Num2 = 10;
                int TwoEntry = Class1.Method1(Num1, Num2);// this line calls the method 
                Console.WriteLine(TwoEntry);
                
            }

            

            
            

            

        }

        
    }
}