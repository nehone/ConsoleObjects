
namespace ConsoleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            int x2 = 0;
            Point p = new Point(x, x2, "A");
            int y = 0;
            int y2 = x2 / 2;
            Point p2 = new Point(y, y2, "B");
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

            p2.Draw();
            p.Draw();
            
            Console.ReadLine();
        }
    }
}