using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDemo
{
    namespace VectorDemo
    {
        class Check
        {
            public void CheckOp(IMathVector vector1, IMathVector vector2, IMathVector vector3)
            {
                Console.WriteLine("expected answer:10");
                Console.WriteLine("test:" + vector1.Length);
                vector1 = (MathVector)vector1 + 2;
                vector1 = (MathVector)vector1 + (MathVector)vector2;
                vector1 = (MathVector)vector1 / 2;
                vector1 = (MathVector)vector1 / (MathVector)vector3;
                double scalar = (MathVector)vector1 % (MathVector)vector3;
                Console.WriteLine("expected answer:6");
                Console.WriteLine("test:" + scalar);
                Console.WriteLine("expected answer:2");
                Console.WriteLine("test:" + vector1.CalcDistance(vector3));
                Console.WriteLine("expected answer:4");
                Console.WriteLine("test: " + vector1.Dimensions);
                Console.WriteLine("expected answer:3 3 3 3");
                Console.WriteLine("test:");
                vector1.OutputVec();
                Console.WriteLine("test:" + vector1.ScalarMultiply(vector3));

            }

            public void CheckValues(IMathVector vector1, IMathVector vector2, IMathVector vector3)
            {
                Console.WriteLine("expected answer:5 5 5 5");
                Console.WriteLine("test:");
                vector1.OutputVec();
                Console.WriteLine("expected answer:5 5 5 5");
                Console.WriteLine("test:");
                vector2.OutputVec();
                Console.WriteLine("expected answer:2 2 2 2");
                Console.WriteLine("test:");
                vector3.OutputVec();
            }
        }
    }
}
