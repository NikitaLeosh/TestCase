using System.Runtime.CompilerServices;

namespace VariousFigureSquare
{
    public class Triangle : ISquareFinder
    {
        private double[] _sides = new double[3]; 
        public Triangle(double ab, double bc, double ca)
        {
            _sides[0] = ab;
            _sides[1] = bc;
            _sides[2] = ca;
        }
        public double FindSquare()
        {
            double P = (_sides[0] + _sides[1] + _sides[2]) /2; //Find half-perimeter;
            return Math.Sqrt(P * (P - _sides[0]) * (P - _sides[1]) * (P - _sides[2]));//Find the triangle square using Heron's formula
        }
        public bool IsRightTriangle()
        {
            Array.Sort(_sides);// locating the longest side to use it as hypotenuse of possible right triangle
            double HypoPow = Math.Round(Math.Pow(_sides[2], 2), 5);
            double CatetsPowSum = Math.Round((Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2)), 5);
            return HypoPow == CatetsPowSum; // Decide if the triangle is right using Pyphagor's theorem.
        }
    }
}