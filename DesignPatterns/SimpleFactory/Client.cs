using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory;

public class Client
{
    static void Main(string[] args)
    {
        // 直接调用工厂生产食物
        Factory.FoodSimpleFactory.CreateFood();
    }
}
