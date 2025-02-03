using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Square
            Square MySquare = new Square(10);
            Console.WriteLine(MySquare.CalculateArea());
            #endregion

            #region Square 2
            Square mysquare2 = new Square(40);
            Console.WriteLine(mysquare2.CalculateArea());
            #endregion

            #region square 3

            Square mysquare3 = new Square(7);
            Console.WriteLine(mysquare3.CalculateArea());
            Console.ReadLine();

            #endregion
        }
    }  
}
