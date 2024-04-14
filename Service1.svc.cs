using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringAnalyzerSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public StringStatistics AnalyzeString(string str)
        {
            StringStatistics stringStat = new StringStatistics();

            stringStat.UppercaseCount = UpperCase(str);
            stringStat.LowercaseCount = LowerCase(str);
            stringStat.DigitCount = DigitCount(str);
            stringStat.VowelCount = VowelCounter(str);

            return stringStat;

        }

        //hopefully we are allowed to use this stuff.
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int UpperCase(string str)
        {
            int upperCount = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    upperCount++;
                }
            }

            return upperCount;
        }

        public int LowerCase(string str)
        {
            int lowerCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    lowerCount++;
                }
            }
            return lowerCount;

        }

        public int DigitCount(string str)
        {
            int digitCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    digitCount++;
                }
            }
            return digitCount;
        }

        public int VowelCounter(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (VowelChecker(input[i]))
                {
                    count++;
                }
            }
            return count;
        }

        private bool VowelChecker(char c)
        {
            c = char.ToUpper(c);
            return (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
        }


    }

}
