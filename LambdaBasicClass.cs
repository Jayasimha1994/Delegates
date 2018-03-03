using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    /// <summary>
    /// basic lambda expression example
    /// </summary>
    class LambdaBasicClass
    {
        private static readonly log4net.ILog log
              = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        delegate void LambdasNoParams();
        static void Main(string[] args)
        {
            LambdasNoParams noparams = () => { log.Info("hello"); };
            noparams();
            Console.Read();
        }
    }
}
