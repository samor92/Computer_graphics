using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_3
{
    class Cone
    {
        private double _Radius;
        private double _Height;
        private int _Slices;

        public Cone()
        {
            Radius = 2;
            Height = 3;
            Slices = 10;
        }

        public int Slices
        {
            get { return _Slices; }
            set { _Slices = value; }
        }

        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
    }
}
