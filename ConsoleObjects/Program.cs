
namespace ConsoleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 18;
            int x2 = 20;
            Point p = new Point(x, x2, "A");
            Sprite s = new Sprite(5,5);
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(18, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.WriteLine("-");
            }
            //Console.WriteLine(p);
            p.Draw();
            s.Draw();
            Console.ReadLine();
        }
    }

    internal class circle
    {
        public bool isinside(Point p, Point p2)
        {


            return true;
        }
    }


}