using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.OberverInterface
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 观察者反应方法
        /// </summary>
        public void Response();
    }
}
