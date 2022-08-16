using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork._1
{
    class Square:Figure
    {
     public Square(float side)
        {
            side = Side;
        }
        private float _side;
        public float Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value>=0)
                {
                    value = _side;
                }


            }
        }

        public override float CalcArea()
        {
            return Side * Side;
        }
    }
}
