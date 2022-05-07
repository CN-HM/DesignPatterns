using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factory
{
    internal class ShenZhenFactory : AbstractFactory
    {
        public override ShenZhenApplePie CreateApplePie()
        {
            throw new NotImplementedException();
        }

        public override ShenZhenBananaPie CreateBananaPie()
        {
            throw new NotImplementedException();
        }
    }
}
