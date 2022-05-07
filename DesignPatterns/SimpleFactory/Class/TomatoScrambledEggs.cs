using DesignPatterns.SimpleFactory.Class;

namespace DesignPatterns.SimpleFactory
{
    public class TomatoScrambledEggs : Food
    {
        public override void Cook()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }
}
