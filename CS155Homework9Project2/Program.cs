using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework9Project2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;

            Console.WriteLine("Hello! Homework 9 Project 2 Temperature class");
            Console.WriteLine("---------------------------------------------\n");

            Console.WriteLine("Creating 2 Temperature objects, #1 at 212F and #2 at 100C");

            Temperature t1 = new Temperature(212.0f, 'F');
            Temperature t2 = new Temperature(100.0f, 'C');

            Console.WriteLine();
            Console.WriteLine("Displaying Temperature object #1 with overridden ToString..");
            Console.WriteLine(t1);
            Console.Write("Get Temperature of object #1 in deg C: ");
            Console.WriteLine(t1.getTemperatureInC());

            Console.WriteLine();
            Console.WriteLine("Displaying Temperature object #2 with overridden ToString..");
            Console.WriteLine(t2);
            Console.Write("Get Temperature of object #2 in deg F: ");
            Console.WriteLine(t2.getTemperatureInF());

            Console.WriteLine();
            s = (t1.Equals(t2)) ? "Yes" : "No";
            Console.WriteLine("Are the two Temperature objects Equal? " + s);

            Console.WriteLine();
            Console.WriteLine("Setting Temperature of the #2 object to 0 deg C");
            t2.setTemperature(0.0f);
            t2.setTempScale('C');
            Console.WriteLine(t2);

            Console.WriteLine();
            s = (t1.Equals(t2)) ? "Yes" : "No";
            Console.WriteLine("Are the two Temperature objects Equal? " + s);

            Console.WriteLine();
            Console.WriteLine("Creating 3 more Temperature objects using 3 different constructors");

            Temperature t3 = new Temperature(212.0f);
            Temperature t4 = new Temperature('C');
            Temperature t5 = new Temperature();


            Console.WriteLine();
            Console.WriteLine("Displaying Temperature object 3 ");
            Console.WriteLine(t3);
            Console.WriteLine("Displaying Temperature object 4 ");
            Console.WriteLine(t4);
            Console.WriteLine("Displaying Temperature object 5 (default constructor)");
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("Setting Temperature of object 3 to 78.0: ");
            t3.setTemperature(78.0f);
            Console.WriteLine("Setting Temperature of object 3 to deg F: ");
            t3.setTempScale('f');


            Console.WriteLine();
            Console.WriteLine("Setting Temperature of object 4 to 44.3: ");
            t4.setTemperature(44.3f);
            Console.WriteLine("Setting Temperature of object 4 to deg C: ");
            t4.setTempScale('C');


            Console.WriteLine();
            Console.WriteLine("Setting Temperature of object 5 to 117.3 deg F: ");
            t5.setTemperatureAndScale(117.3f, 'F');

            Console.WriteLine();
            Console.WriteLine("Now, rewriting all 3 Temperature objects, t3, t4 and t5");
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("End of testing..");
            Console.Read();
        }
    }
}
