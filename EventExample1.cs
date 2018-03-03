using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate void MyEventHandler(string newValue);
    /// <summary>
    /// class for declaring things required for events.
    /// </summary>
    class EventExample
    {
        private static readonly log4net.ILog log
               = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string theValue;
        public event MyEventHandler valueChanged;
        public string Val
        {
            set
            {
                this.theValue = value;
                this.valueChanged(theValue);
            }
        }
    }
    /// <summary>
    /// class for instantiating and executing the events.
    /// </summary>
    class EventExample1
    {
        private static readonly log4net.ILog log
               = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            EventMethod();
        }
        /// <summary>
        /// instantiating delegate and event.
        /// </summary>
        static void EventMethod()
        {
            EventExample myEvt = new EventExample();
            myEvt.valueChanged += new MyEventHandler(myEvt_valueChanged);
            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                    myEvt.Val = str;
            } while (!str.Equals("exit"));
        }
        /// <summary>
        /// method to check whether event occured or not.
        /// </summary>
        /// <param name="newValue"></param>
        static void myEvt_valueChanged(string newValue)
        {
            log.Info("the value changed to : "+newValue);
        }
    }
}
