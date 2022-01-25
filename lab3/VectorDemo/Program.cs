using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDemo.VectorDemo;

namespace VectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMathVector vector1 = new MathVector(4, 5);
                IMathVector vector2 = new MathVector(4, 5);
                IMathVector vector3 = new MathVector(4, 2);
                // IMathVector vector4 = new MathVector(3);
                Check test = new Check();
                test.CheckOp(vector1, vector2, vector3);
                test.CheckValues(vector1, vector2, vector3);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            Console.ReadKey();
        }
    }
}
