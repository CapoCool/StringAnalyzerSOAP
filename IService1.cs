using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringAnalyzerSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Reverse(string str);

        [OperationContract]
        StringStatistics AnalyzeString(string str);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class StringStatistics
    {
        [DataMember]
        public int UppercaseCount { get; set; }

        [DataMember]
        public int LowercaseCount { get; set; }

        [DataMember]
        public int DigitCount { get; set; }

        [DataMember]
        public int VowelCount { get; set; }
    }
}
