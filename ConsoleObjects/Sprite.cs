using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjects
{
    internal class Sprite : Point
    {
        public Sprite(int x, int y) : base(x, y)
        {

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("X");
        }

    }
}
