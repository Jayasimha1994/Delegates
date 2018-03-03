using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    /// <summary>
    /// delegate declaration.
    /// </summary>
    /// <param name="name"></param>
    public delegate void FirstDelegate1(string name);
    /// <summary>
    /// class to perform multi delegate function.
    /// </summary>
    class MultiCastDelegate
    {
        private static readonly log4net.ILog log
                = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// first method for its one type of task
        /// </summary>
        /// <param name="name"></param>
        public static void ShowFirst(string name)
        {
            log.Info("Show delegate");
        }
        /// <summary>
        /// second method for different task
        /// </summary>
        /// <param name="name"></param>
        public static void ShowSecond(string name)
        {
            log.Info("Show second delegate");
        }
        /// <summary>
        /// instantiating the delegate.
        /// </summary>
        static void CallDelegate()
        {
            FirstDelegate1 f = new FirstDelegate1(ShowFirst);
            f += ShowSecond;
            f("some");
        }
        /// <summary>
        /// entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CallDelegate();
            Console.Read();
        }
    }
}
