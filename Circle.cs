using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle
    {
       private int _Radius; // This is a private field for radius
        
        public Circle(int radius) // This is a constructor for the Circle 
        {
            _Radius = radius; // This is constructor for the value of the radius
        }       
        public double GetArea()  => Math.Pow(_Radius, 2) * Math.PI; // This is the publice method for GetArea and Get the results
    }
}
