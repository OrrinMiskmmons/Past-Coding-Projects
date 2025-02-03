using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Square
    {

        private int lenght;

        public int Length
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int CalculateArea()
        {
            return lenght * lenght;
        }

        public Square(int squareLength)
        {
            Length = squareLength;
        }
    }
}
