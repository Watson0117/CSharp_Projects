﻿using System;

namespace _6PartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            string input = Console.ReadLine();

            for (int j = 0; j < names.Length; j++) ;
            {
                int j = 0;
                names[j] = names[j] + input;
            }
            Console.WriteLine(names);
            Console.ReadLine();
        }
    }
}