using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework9Project1
{
    class Odometer
    {
        private int milesdriven;
        private double fuelUsage;

        public Odometer()
        { }

        public int Miles { get => milesdriven; set => milesdriven = value; }
        public double FuelUsage { get => fuelUsage; set => fuelUsage = value; }

        public void reset()
        {
            milesdriven = 0;
            fuelUsage = 0;
        }

        public void add(int m, double f)
        {
            milesdriven += m;
            fuelUsage += f;
        }

        public double calcMPG()
        {
            if (fuelUsage != 0.0)
                return milesdriven / fuelUsage;
            else
                return 0.0;
        }

        public string toString()
        {
            return "Miles driven: " + milesdriven.ToString() + " Fuel Usage: " + fuelUsage.ToString() + " Average mileage: " + calcMPG().ToString("###.#");
        }
    }
}
