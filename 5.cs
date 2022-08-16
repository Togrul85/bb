using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._1
{
    class Rectangular : Figure
    {
        public Rectangular(float width, float length)
        {
            width = Width;
            length = Length;
        }
        private float _width;
        private float _length;
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
            }
        }
        public float Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
            }


        }

        public override float CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
