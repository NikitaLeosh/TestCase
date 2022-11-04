using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousFigureSquare
{
    public class Round : ISquareFinder
    {
        private double _radius;
        public Round(double radius)
        {
            _radius = radius;
        }
        public double FindSquare()
        {
            return (Math.PI * Math.Pow(_radius, 2));
        }
    }
}
