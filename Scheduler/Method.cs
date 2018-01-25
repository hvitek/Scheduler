using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Method
    {
        public String methodName {get;set;}
        public Type methodReturnType { get; set; }
        public ICustomAttributeProvider methodReturnTypeCustomAttributes { get; set; }

    }
}
