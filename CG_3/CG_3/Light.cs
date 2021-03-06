﻿using System.Drawing;

namespace CG_3
{
    class Light
    {
        private int _x;
        private int _y;
        private int _z;
        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
    }
}
