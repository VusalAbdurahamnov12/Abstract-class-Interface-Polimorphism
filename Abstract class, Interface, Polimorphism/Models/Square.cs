using System;
using System.Collections.Generic;
using System.Text;
using Abstract_class__Interface__Polimorphism.Models;

namespace Abstract_class__Interface__Polimorphism.Models
{
    class Square : Figure
    {
        private double _side { get; set; }
        public Square(double side)
        {
            _side = side;
        }
        public override double CalcArea()
        {
            return _side * _side;
        }
    }
}
