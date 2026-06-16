using Stars._2_WithInterface;

namespace Stars
{
    internal class Demo2Interface
    {
        public static void Run()
        {
            Console.CursorVisible = false;
            var stars = new IStar[]
            {
                new BlinkingStar(10, 5),
                new BlinkingStar(11, 15),
                new MovingStar(5, 10),
                // new SomeOtherKindOfStart(10,10),
            };
            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Thread.Sleep(100);
            }
        }
    }
}
