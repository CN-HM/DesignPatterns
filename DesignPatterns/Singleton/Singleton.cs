using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton? instance;

        /// <summary>
        /// 构造函数
        /// 定义私有构造函数，使外界不可直接创建该类型实例
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// 定义共有方法
        /// 提供一个全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            if (instance == null)
                return new Singleton();
            else
                return instance;
        }
    }
}
