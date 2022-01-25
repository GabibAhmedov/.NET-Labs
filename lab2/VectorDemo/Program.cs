using System;
using LinearAlgebra;

namespace VectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IMathVector vector1 = new MathVector(4, 5);
            IMathVector vector2 = new MathVector(4, 5);
            IMathVector vector3 = new MathVector(4, 2);               
            try
            {
                Check test = new Check();
                test.CheckMeth(vector1, vector2, vector3);
                test.CheckValues(vector1, vector2, vector3);
                /*
                vector3 = (MathVector)test/(MathVector)vector1;
                vector3 = vector3 - 2;
                vector3 = vector3 + vector3;
                Console.WriteLine(vector1.Dimensions);
                Console.WriteLine(vector1.Length);*/


                //    test = vector1.Sum(vector3);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
