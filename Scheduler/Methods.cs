using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Methods
    {
        public void execute()
        {
            string methodName = "ExecuteSomething4";

            //Get the method information using the method info class
            MethodInfo mi = this.GetType().GetMethod(methodName);

            //Invoke the method
            // (null- no parameter for the method call
            // or you can pass the array of parameters...)

            int numOfArgs = mi.GetParameters().Count();

            Object[] args = new Object[numOfArgs];

            if (numOfArgs != 0)
            {
                for (int i = 0; i < numOfArgs; i++)
                {
                    args[i] = null;
                    // args[i] = getArgument(i);
                }
            }
            else
                args = null;



            mi.Invoke(this, args);

        }

        
  
        public void PrintData(string param1, int param2)
        {
            int a = 55;
        }


        public Boolean ExecuteSomething()
        { 
            try
            {
                int a = 55;
                
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public void ExecuteSomething1(string param1, string param2)
        {
            int a = 55;
        }

        public void ExecuteSomething2(string param1, string param2)
        {
            int a = 55;
        }

        public void ExecuteSomething3(string param1, int param2)
        {
            int a = 55;
        }

        public void ExecuteSomething4(dynamic MyDynamic)
        {
            int a = 55;
        }



    }
    
}
