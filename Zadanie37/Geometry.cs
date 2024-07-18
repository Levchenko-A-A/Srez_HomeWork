using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie37
{
    internal class Geometry
    {
        private double sideOne;
        private double sideTwo;

        public Geometry(double sideOne, double sideTwo)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
        }

        //public double getSideOne() => sideOne;
        //public double getSideTwo() => sideTwo;
        //public double setSideOne(double sideOne) => this.sideOne=sideOne;
        //public double setSideTwo(double sideTwo) => this.sideTwo=sideTwo;

        public double squreArea()
        {
            return sideOne * sideTwo;
        }

        public double perimeterlArea() 
        {
            return (sideOne + sideTwo)*2;
        }

        public double diagonalArea()
        {
            return Math.Sqrt(Math.Pow(sideOne, 2)+Math.Pow(sideTwo, 2));
        }





    }
}
