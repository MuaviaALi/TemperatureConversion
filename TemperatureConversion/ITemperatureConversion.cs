using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TemperatureConversion
{


    [DataContract]
    public enum Convert
    {
        [EnumMember]
        FAHRENHEIT,
        [EnumMember]
        CELSIUS,
        [EnumMember]
        KELVIN,

    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITemperatureConversion
    {
        [OperationContract]
        double ConvertTempreture(double val, Convert from, Convert to);

    }
}
