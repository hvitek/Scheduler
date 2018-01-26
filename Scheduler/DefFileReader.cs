using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class DefFileReader
    {
        List<MethodModel> list;
        public DefFileReader()
        {
            list = new List<MethodModel>();
            read();
        }
        private void read()
        {
            char separator = 'ł';
            string defText =
                            @"  łdefFileStartTimesł
                                [IN]
                                łNameł
                                łExceptionStartTime;ExceptionStartTime;ExceptionStartTime;ł
                                łmethodClassł
                                łmethodNameł
                                łparamType;paramType;paramType;paramType;ł
                                łparamNames;paramNames;paramNamesł
                                łparamValues;paramValues;paramValues;ł
                                łdefaultOUTNameł
                                łexceptionOUTNameł
                                [OUT]
                                łNameł
                                łmethodNameł
                                łAddnationalParamType;AddnationalParamType;AddnationalParamTypeł
                                łAddnationalParamName;AddnationalParamName;AddnationalParamNameł
                                łAddnationalParamValue;AddnationalParamValue;AddnationalParamValueł";

            string[] words = defText.Split(separator);
          //  string[] selectt = words.split;

        }

        public List<MethodModel> getMethods()
        {
            return list;
        }
        
    }
}
