using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class SingletonWithLocker
    {
        // 定义一个静态变量来保存类的实例
        private static SingletonWithLocker? instance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        /// <summary>
        /// 私有构造函数
        /// 禁止外部实例化
        /// </summary>
        private SingletonWithLocker()
        {
        }

        public static SingletonWithLocker Instance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (instance == null)
            {
                lock (locker)
                {
                    instance = new SingletonWithLocker();
                }
            }
            
            return instance;
        }
    }
}
