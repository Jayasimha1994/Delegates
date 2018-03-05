using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProject
{
    /// <summary>
    /// it will explain the types of Delegates and usage.
    /// </summary>
    class DelegatesTypes
    {
        private static readonly log4net.ILog log
       = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// method for Delegates execution.
        /// </summary>
        public static void DoTask()
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = obj1.Invoke(20, 1.5f, 5.2);
            log.Info(result);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                log.Info(x + y + z);
            };
            obj2.Invoke(20, 1.5f, 5.2);
            Predicate<string> obj3 = (name) =>
            {
                if (name.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("bangalore");
            log.Info(status);
        }
        static void Main(string[] args)
        {
            DoTask();
            Console.Read();
        }
    }
}
