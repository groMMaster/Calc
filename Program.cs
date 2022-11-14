using System;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ConsoleApp24
{
    public struct Root
    {
        public double Value { get; }
        public Root(double value)
        {
            Value = value;
        }
    }

    public interface IEquation
    {
        Root GetRoot();
    }

    public class Line : IEquation
    {
        public double A;
        public double B;

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }

        public Root GetRoot()
        {
            if (A == 0)
            {
                if (B == 0) return new Root(0);
                throw new Exception();
            }

            return new Root(B / A);
        }
    }
}
