﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjects
{

    public class Point
    {
        private int x; private int y; private string name;

        public Point(int xCoor, int yCoor, string nammme)
        {
            x = xCoor;
            y = yCoor;
            name = nammme;
        }
        public int Getx() // getter
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }
        public string GetName()
        {
            return name;
        }
        public void SetX(int value)
        {
            if (x <= 100)
            {
                x = value;
            }
        }

        public override string ToString()
        {
            return $"{name}({x},{y})";
        }

        public int intager()
        {
            if (x > 0 && y > 0)
                return 1;

            else if (x < 0 && y > 0)
                return 2;

            else if (x < 0 && y < 0)
                return 3;

            else if (x > 0 && y < 0)
                return 4;

            else return -1;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x + 20, -y + 20);
            Console.WriteLine(this);

        }
}
}


