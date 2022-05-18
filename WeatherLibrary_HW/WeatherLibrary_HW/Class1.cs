using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary_HW
{
    public class WeatherLibraryFuncs
    {
        public static double FahrToCel(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }

        public static double FahrToKelv(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }

        public static double CelToFahr(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double CelToKelv(double celsius)
        {
            return celsius + 273.15;
        }

        public static double HeatIndex(double f, double rh)
        {
            return -42.379 + (2.04901523 * f) + (10.14333127 * rh) - (0.22475541 * f * rh) - (0.00683783 * f * f) 
                - (0.5481717 * rh * rh) + (0.00122875 * f * f * rh) + (0.00085282 * f * rh * rh) - (0.00000199 * f * f * rh * rh);
        }

        public static double WindChill(double s, double f)
        {
            return 35.74 + (0.6215 * f) - 35.75 * (Math.Pow(s, 0.16)) + 0.4275 * f * (Math.Pow(s, 0.16));
        }

        public static double RealtiveHumidity(double s, double a)
        {
            return s / a * 100;
        }

        public static double MphToKnots(double speed)
        {
            return speed / 1.151;
        }

        public static double KnotsToMph(double speed)
        {
            return speed * 1.151;
        }

    } // end class
} // end namespace
