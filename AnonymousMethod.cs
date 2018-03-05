using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProject
{
    /// <summary>
    /// Delegate to for adding two numbers.
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public delegate int AddDelegate(int num1, int num2);
    /// <summary>
    /// Class uses anonymous method for the functional logic.
    /// </summary>
    class AnonymousMethod
    {
        private static readonly log4net.ILog log
       = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //public static int Add(int num1,int num2)
        //{
        //    return num1 + num2;
        //}
        static void Main(string[] args)
        {
            //AddDelegate add = new AddDelegate(Add);
            AddDelegate add = delegate (int i, int j)
            {
                return i + j;
            };
            log.Info("enter numbers");
            int result = add.Invoke(100, 200);
            log.Info(result);
            Console.Read();
        }
    }
}
