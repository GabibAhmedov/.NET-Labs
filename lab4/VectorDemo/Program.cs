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
                IMathVector vector4 = new MathVector(new List<double> { 1, 2, 3, 4, 5 });
                Check test = new Check();
                test.CheckOp(vector1, vector2, vector3);
                test.CheckValues(vector1, vector2, vector3,vector4);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            Console.ReadKey();
        }
    }
}
