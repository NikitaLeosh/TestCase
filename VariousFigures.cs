using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousFigureSquare
{
    public class VariousFigures
    {
        public static double FindFigureSquare(double ab, double bc, double ca)
        {
            Triangle abc = new(ab, bc, ca);
            return abc.FindSquare();
        }
        public static double FindFigureSquare(double r)
        {
            Round round = new(r);
            return round.FindSquare();
        }
    }
}
