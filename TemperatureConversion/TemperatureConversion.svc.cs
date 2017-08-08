using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TemperatureConversion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TemperatureConversion : ITemperatureConversion
    {

        public double ConvertTempreture(double val, Convert from, Convert to)
        {

            if (from == Convert.FAHRENHEIT && to == Convert.FAHRENHEIT)
            {
                return val;

            }
            else if (from == Convert.CELSIUS && to == Convert.CELSIUS)
            {
                return val;

            }
            else if (from == Convert.KELVIN && to == Convert.KELVIN)
            {
                return val;

            }
                //FAHRENHEIT TO CELSIUS AND CELSIUS TO FAHRENHEIT
            else if (from == Convert.FAHRENHEIT && to == Convert.CELSIUS)
            {
                var firstval = (val - 32);
                var secondval = (firstval * .5556);
                return secondval;
            }
            else if(from == Convert.CELSIUS && to == Convert.FAHRENHEIT)
            {
                var firstval = (val * 1.8);
                var secondval = (firstval + 32);
                return secondval;
            }
            //FAHRENHEIT TO KALVIN AND KALVIN TO FAHRENHEIT
            else if (from == Convert.FAHRENHEIT && to == Convert.KELVIN)
            {
                var firstval = (val - 32);
                var secondval = (firstval * 5 / 9 + 273.15);
                return secondval;
            }
            else if (from == Convert.KELVIN && to == Convert.FAHRENHEIT)
            {

                return (val - 273.15) * 9 / 5 + 32;

            }
                 //CELSIUS TO KELVIN AND KELVIN TO CELSIUS
           
            else if (from == Convert.KELVIN && to == Convert.CELSIUS)
            {
                return val - 273;
            }
            else 
            {
                return val + 273;
            }
           
            
           
        }
    }
}

