using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProject
{
    /// <summary>
    /// Types of Delegates by invoking methods.
    /// </summary>
    class GenericDelegates
    {
        private static readonly log4net.ILog log
       = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //public delegate double Delegate1(int x, float y, double z);
        //public delegate void Delegate2(int x, float y, double z);
        //public delegate bool Delegate3(string str);
        public static double AddNum1(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void AddNum2(int x,float y,double z)
        {
            log.Info(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length>5)
                return true;
            return false;
        }
        /// <summary>
        /// method in which the delegates invokes the defined methods.
        /// </summary>
        public static void DelegateTask()
        {
            Func<int, float, double, double> obj1 = AddNum1;
            double result = obj1.Invoke(20, 1.5f, 5.2);
            log.Info(result);

            Action<int, float, double> obj2 = AddNum2;
            obj2.Invoke(20, 1.5f, 5.2);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello");
            log.Info(status);
        }
        static void Main(string[] args)
        {
            DelegateTask();
            Console.Read();
        }
    }
}
