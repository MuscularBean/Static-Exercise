using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        { }
       

        public static double FahrenheitToCelsius(double fr)
        {       

            double cel = (fr - 32) * 5 / 9;

            return cel;


        }
        
        public static double CelsiusToFahrenheit(double cel)
        {

            double fr = (cel * 9) / 5 + 32;

            return fr;
        }


    }
}
