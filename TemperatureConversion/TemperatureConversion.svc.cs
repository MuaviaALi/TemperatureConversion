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
            if (from == Convert.FAHRENHEIT)
            {
                if (to == Convert.FAHRENHEIT)
                {

                    return val;

                }
                else
                {
                    
                    var firstval = (val - 32);
                    var secondval = (firstval * .5556) ;
                    return  secondval;
                }
            }
            else
            {
                if (to == Convert.FAHRENHEIT)
                {
                    var firstval = (val * 1.8);
                    var secondval = (firstval + 32);
                    return secondval;

                }
                else
                {

                    return val;
                }
            }
        }
    }
}
