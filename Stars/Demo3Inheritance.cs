using Stars._3_WithInheritance;

namespace Stars
{
    internal class Demo3Inheritance
    {
        public static void Run()
        {
            Console.CursorVisible = false;
            var stars = new Star[]
            {
                new BlinkingStar(10, 5),
                new MovingStar(5, 10),
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
