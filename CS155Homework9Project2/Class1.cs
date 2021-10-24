using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework9Project2
{
    class Temperature
    {
        private float temperature;
        private char scale;

        //constructor #1
        public Temperature()
        {
            temperature = 0;
            scale = 'C';

        }

        //constructor #2
        public Temperature(float t)
        {
            temperature = t;
        }

        //constructor #3
        public Temperature(char c)
        {
            if (c == 'C' || c == 'F' || c == 'c' || c == 'f')
                scale = c;
            else
            { 
                scale = 'U'; //Unknown
                Console.WriteLine("Invalid scale. Temperature set to Unknown scale!");
            } 
        }

        //constructor #4
        public Temperature(float t, char c)
        {
            temperature = t;
            if (c == 'C' || c == 'F' || c == 'c' || c == 'f')
                scale = c;
            else
            {
                scale = 'U'; //Unknown
                Console.WriteLine("Invalid scale. Temperature set to Unknown scale!");
            }

        }


        public float getTemperatureInF()
        {
            if (scale == 'F' || scale == 'f')
                return (float) Math.Round(temperature, 1);
            else
                return (float) Math.Round((temperature * 1.8 + 32.0), 1);          //Temp scale must be converted..
        }

        public float getTemperatureInC()
        {
            if (scale == 'C' || scale == 'c')
                return (float) Math.Round(temperature, 1);
            else
                return (float) Math.Round(((temperature - 32.0)/ 1.8), 1);          //Temp scale must be converted..

        }
        //public double FuelUsage { get => fuelUsage; set => fuelUsage = value; }

        public void setTemperature(float t)
        {
            temperature = t;
        }

        public char getTempScale()
        {
            if (scale == 'C' || scale == 'c')
                return 'C';
            else
                return 'F';
        }
        public void setTempScale(char c)
        {
            if (c == 'C' || c == 'F' || c == 'c' || c == 'f')
                scale = c;
            else
            {
                scale = 'U'; //Unknown
                Console.WriteLine("Invalid scale. Temperature set to Unknown scale!");
            }
        }


        public void setTemperatureAndScale(float t, char c)
        {
            temperature = t;
            if (c == 'C' || c == 'F' || c == 'c' || c == 'f')
                scale = c;
            else
            {
                scale = 'U'; //Unknown
                Console.WriteLine("Invalid scale. Temperature set to Unknown scale!");
            }

        }

        public bool Equals(Temperature oT)
        {
            if (this.getTemperatureInF() == oT.getTemperatureInF())
                return true;

            return false;
        }

        public override string ToString()
        {
            string s;
            s = "Temperature is: " + temperature.ToString("#####.0") + " deg " + scale.ToString();

            return s;

            //return base.ToString();
        }
    }
}
