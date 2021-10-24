using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework9Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! CS155 Homework 9 - Project 1");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Creating 2 Odometers, 1 default constructor + 1 initializing to the first one!");
            Odometer om = new Odometer();
            Odometer om2 = om;

            Console.WriteLine();
            Console.WriteLine("Displaying Odometer");
            Console.WriteLine(om.toString());
            Console.WriteLine();
            Console.WriteLine("Adding Miles and fuel");
            om.add(100, 4.0);
            Console.WriteLine(om.toString());

            Console.WriteLine();
            Console.WriteLine("Resetting Odometer");            
            om.reset();
            Console.WriteLine(om.toString());
            
            Console.WriteLine();
            Console.WriteLine("Adding Miles and fuel");
            om.add(50, 2.3);
            Console.WriteLine(om.toString());
            om.add(500, 20.0);
            Console.WriteLine(om.toString());

            Console.WriteLine();
            Console.WriteLine("Displaying the 2nd Odometer..");
            Console.WriteLine("Initializing the 2nd Odometer to the first one has undesired consequence.");
            Console.WriteLine("Object set to a previous object on the heap points to the same memory!");
            Console.WriteLine("Any change to the 2nd WILL AFFECT THE FIRST ODOMETER (points to same memory)");
            Console.WriteLine(om2.toString());
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
