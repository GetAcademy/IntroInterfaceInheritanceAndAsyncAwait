using Stars._1_Plain;

namespace Stars
{
    internal class Demo1Plain
    {
        public static void Run()
        {
            Console.CursorVisible = false;
            var blinkingStar = new BlinkingStar(10, 5);
            var movingStar = new MovingStar(5, 10);
            while (true)
            {
                Console.Clear();
                blinkingStar.Show();
                movingStar.Show();
                blinkingStar.Update();
                movingStar.Update();
                Thread.Sleep(100);
            }
        }
    }
}
