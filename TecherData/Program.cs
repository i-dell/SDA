﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherData
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string name, section;

            Console.WriteLine("___________________TeacherData__________________");
            Console.WriteLine("  ");
            Console.Write("Enter the ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Teacher Name: ");
            name = Console.ReadLine();

            Console.Write("Enter the Section: ");
            section = Console.ReadLine();

            Console.WriteLine("  ");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("  ");
            Console.WriteLine("The ID is: " + ID + ",   The name is: " + name + ",  The Section is: " + section);
            Console.WriteLine("  ");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Thankyou!! by Adil Alammari");
            Console.ReadLine();



        }
    }
}
