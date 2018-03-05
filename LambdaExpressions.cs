using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProject
{
    /// <summary>
    /// delegate to point the methods for adding numbers.
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public delegate int AddNumbers(int num1, int num2);
    /// <summary>
    /// Class for a simple Lambda Expression.
    /// </summary>
    class LambdaExpressions
    {
        private static readonly log4net.ILog log
       = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static int count;
        /// <summary>
        /// method to add the first 10 numbers using lambda expression.
        /// </summary>
        public static void Add()
        {
            AddNumbers a = (i, j) =>
            {
                for (int b = i; b <= j; b++)
                {
                    count += b;
                }
                return count;
            };
            int result = a.Invoke(1, 10);
            log.Info("First ten digits added values is :"+result);
        }
        static void Main(string[] args)
        {
            Add();
            Console.Read();
        }
    }
}
