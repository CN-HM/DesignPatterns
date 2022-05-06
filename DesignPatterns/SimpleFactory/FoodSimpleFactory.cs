namespace DesignPatterns.SimpleFactory
{
    public class FoodSimpleFactory
    {
        public static Food CreateFood()
        {
            return new TomatoScrambledEggs();
        }
    }
}
