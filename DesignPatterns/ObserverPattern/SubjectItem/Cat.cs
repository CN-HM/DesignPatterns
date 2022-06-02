using DesignPatterns.ObserverPattern.OberverInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.SubjectItem
{
    public class Cat : ISubject
    {
        private static List<IObserver> observerList;

        public Cat() {
            observerList = new List<IObserver>();
        }

        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void Cry()
        {
            Console.WriteLine("猫叫了...");

            foreach (var item in observerList)
            {
                //动态数组在存入Observer对象时，会把它当作基类(Object)对象存储，
                //所以在取出使用时需要显示转换为Observer类型的对象
                item.Response();
            }
        }
    }
}
