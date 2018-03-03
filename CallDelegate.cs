using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    /// <summary>
    /// class for Calling a delegate of another class.
    /// </summary>
    public class CallDelegate
    {
        private static readonly log4net.ILog log
                = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// get information from another class through delegate.
        /// </summary>
        /// <param name="i"></param>
        static void CallBack(int i)
        {
            log.Info("Program :" + i);
        }
        static void Call()
        {
            MyClass m = new MyClass();
            m.LongRunningMethod(CallBack);
        }
        static void Main(string[] args)
        {
            Call();
            Console.Read();
        }
    }
    /// <summary>
    /// delegate creating inside the class which sends the information to the 
    /// call back classes.
    /// </summary>
    class MyClass
    {
        private static readonly log4net.ILog log
                = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public delegate void CallBack(int i);
        /// <summary>
        /// methods sends the resulting info to the class where delegate is instantiated.
        /// </summary>
        /// <param name="obj"></param>
        public void LongRunningMethod(CallBack obj)
        {
            for (int i = 0; i < 100; i++)
            {
                log.Info(i);
            }
        }
    }
}
