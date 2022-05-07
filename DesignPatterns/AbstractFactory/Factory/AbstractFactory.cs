using DesignPatterns.AbstractFactory.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factory
{
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 生成苹果派
        /// </summary>
        /// <returns></returns>
        public abstract ApplePie CreateApplePie();

        /// <summary>
        /// 生成香蕉派
        /// </summary>
        /// <returns></returns>
        public abstract BananaPie CreateBananaPie();
    }
}
