using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class MethodModel
    {
        public String name { get; set; }
        public String methodClass { get; set; }
        public String methodName { get; set; }
        public String[] paramType { get; set; }
        public String[] paramNames { get; set; }
        public String[] paramValues { get; set; }
        public String defaultOUTName { get; set; }
        public String[] exceptionOUTNameAndCondition { get; set; }
        public Type methodReturnType { get; set; }
        public ICustomAttributeProvider methodReturnTypeCustomAttributes { get; set; }
        public String[] valueParams { get; set; }
        public String[] exceptionStartTime { get; set; }
        
    }
}
