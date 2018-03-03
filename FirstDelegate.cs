using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    /// <summary>
    /// delegate for adding to numbers.
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    public delegate void AddNum(int i, int j);
    /// <summary>
    /// delegate which takes string as parameter.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public delegate string SayHello(String name);
    /// <summary>
    /// class where the delegates are instantiating and utilizing.
    /// </summary>
    public class FirstDelegate
    {
        private static readonly log4net.ILog log
              = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void AddNum(int a, int b)
        {
            log.Info(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        /// <summary>
        /// delegate intantiating method.
        /// </summary>
        static void CallBack()
        {
            FirstDelegate p = new FirstDelegate();
            AddNum a = new AddNum(p.AddNum);
            a(10, 20);
            SayHello s = new SayHello(SayHello);
            string str = s("jayasimha");
            log.Info(str);
        }
        static void Main(string[] args)
        {
            CallBack();
            Console.Read();
        }
    }
}
