using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class__Interface__Polimorphism.Models
{
    internal class Rectangular : Figure
    {
        public double _width { get; set; }
        public double _lentgh { get; set; }

        public Rectangular(double width,double length )
        {
            _width = width;
            _lentgh = length;
        }
        public override double CalcArea()
        {
            return _width * _lentgh;
        }
    }
}
