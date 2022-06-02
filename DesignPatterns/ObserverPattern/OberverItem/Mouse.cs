using DesignPatterns.ObserverPattern.OberverInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.OberverItem
{
    /// <summary>
    /// 观察对象-老鼠
    /// </summary>
    public class Mouse : IObserver
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="subject"></param>
        public Mouse(ISubject subject) {
            subject.AddObserver(this);
        }

        /// <summary>
        /// 反应动作/通知
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Response()
        {
            Console.WriteLine("通知开始，老鼠开始跑了~");
        }
    }
}
