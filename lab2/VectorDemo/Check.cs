using System;
using System.Collections.Generic;
using System.Text;
using LinearAlgebra; 

namespace VectorDemo
{
    class Check
    {
        public void CheckMeth(IMathVector vector1,IMathVector vector2,IMathVector vector3 )
        {
            Console.WriteLine("expected answer:10");
            Console.WriteLine(vector1.Length);
            vector1 = (MathVector) vector1+2;
            vector1 = (MathVector) vector1 + (MathVector)vector2;
            vector1 = (MathVector)vector1 / 2;
            vector1 = (MathVector) vector1 / (MathVector)vector3;
            Console.WriteLine("expected answer:4");
            Console.WriteLine("test: " + vector1.Dimensions);
           
            Console.WriteLine("expected answer:3 3 3 3");
            Console.WriteLine("test:");
            vector1.OutputVec();
        }


        public void CheckValues(IMathVector vector1, IMathVector vector2, IMathVector vector3)
        {
            Console.WriteLine("expected answer:5 5 5 5");
            Console.WriteLine("test:");
            vector1.OutputVec();
        }

}
}
