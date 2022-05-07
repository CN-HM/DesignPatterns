using DesignPatterns.AbstractFactory.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factory
{
    public class ChangShaFactory : AbstractFactory
    {
        public override ApplePie CreateApplePie()
        {
            return new ChangShaApplePie();
        }

        public override BananaPie CreateBananaPie()
        {
            return new ChangShaBananaPie();
        }
    }
}
