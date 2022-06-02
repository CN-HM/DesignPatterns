using DesignPatterns.ObserverPattern.OberverInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.OberverItem
{
    /// <summary>
    /// 观察对象-主人
    /// </summary>
    public class Host : IObserver
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="subject"></param>
        public Host(ISubject subject)
        {
            subject.AddObserver(this);
        }

        public void Response()
        {
            Console.WriteLine("通知开始，主人被惊醒了。。。");
        }
    }
}
