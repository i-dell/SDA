﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecherData
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string name, section, input;

            Console.WriteLine("Enter the ID: ");
            input = Console.ReadLine();
            ID = Convert.ToInt64();

            Console.WriteLine("Enter the Techer Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Section: ");
            section = Console.ReadLine();

            Console.WriteLine("The ID is:  " + ID + " The name is:  " + name + "The Section is: " + section);
            Console.ReadLine();

 
        }
    }
}
