using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.OberverInterface
{
    /// <summary>
    /// 观察对象
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 添加观察对象
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer);
    }
}
