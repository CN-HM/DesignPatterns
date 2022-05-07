using DesignPatterns.SimpleFactory.Class;

namespace DesignPatterns.SimpleFactory.Factory
{
    /// <summary>
    /// 简单工厂 生产的东西由传入值决定
    /// 优化方案为抽象工厂
    /// </summary>
    public class FoodSimpleFactory
    {
        public static Food CreateFood(int type)
        {
            Food food;

            switch (type)
            {
                case 0:
                    food = new TomatoScrambledEggs();
                    break;
                case 1:
                    food = new ShreddedPorkWithPotatoes();
                    break;
                default:
                    food = new TomatoScrambledEggs();
                    break;
            }

            return food;
        }
    }
}
