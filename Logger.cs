using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singeton
{
  public  class Logger
    {

        static Logger instance;
        static readonly object lockObject = new object();
        Logger()
        {

            Console.Write("Logger constructor called");


        }

        public static Logger Wywolajinstancje()
        { 
          System.Console.WriteLine("wywolanie");
            if (null == instance)
            {
            
                lock (lockObject)
                {
                    if (null == instance)
                    {

                        instance = new Logger();
                    }

                }
            }
            return instance;

        }
    }
}
