using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateProject
{
    /// <summary>
    /// Class to perform the async and await functionality
    /// </summary>
    class AsyncAwaitClass
    {
        private static readonly log4net.ILog log
                = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Method();
            log.Info("main method ");
            Console.Read();
        }
        /// <summary>
        /// using async and await combination to check their behavior.
        /// </summary>
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            log.Info("new Thread");
        }
        /// <summary>
        /// The current thread has made to sleep for 5 seconds to check
        /// await operation.
        /// </summary>
        public static void LongTask()
        {
            Thread.Sleep(5000);
        }
    }
}
