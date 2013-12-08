using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class myPoint
    {
        private int _x, _y;
        private Boolean _isOnSegment;

        public bool IsOnSegment
        {
            get { return _isOnSegment; }
            set { _isOnSegment = value; }
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
