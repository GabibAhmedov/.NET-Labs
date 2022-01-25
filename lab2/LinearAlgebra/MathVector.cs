using System;
using System.Collections;

namespace LinearAlgebra
{ 
	
	public class MathVector : IMathVector
	{
		/*public double _x;
		public double _y;
		public double _z;*/
		private double[] _arr;
		private int _dimensionscount;
		private int _capacity;
		public MathVector()
		{
			_dimensionscount = 0;
			_capacity = 2 * _dimensionscount;
			_arr = null;
		}
		public MathVector(int size, double value)
		{
			_dimensionscount = size;
			_capacity = _dimensionscount * 2;
			_arr = new double[_capacity];
			for (int i = 0; i != size; ++i)
				_arr[i] = value;
		}
		public void OutputVec()
        {
			for (int i = 0; i < _dimensionscount; i++)
			{
				Console.WriteLine(this[i]);
			}
		}
		public int Dimensions
		{
			get	{ return _dimensionscount; }
		}

		public double this[int i]
		{
			get	{ return _arr[i]; }
			set	{ _arr[i] = value; }

		}
		public double Length
		{
			get
			{
				double summS = 0;
				for (int i=0; i<_dimensionscount;i++)
                {
					
					summS = summS + (_arr[i] * _arr[i]);
                }
				return Math.Sqrt(summS);					
			}
		}
		public IMathVector SumNumber (double number)
        {
			IMathVector tmpVec = new MathVector(_dimensionscount,0);
			for (int i = 0; i < _dimensionscount; i++)
			{
				tmpVec[i] = _arr[i]+number;
			}
			return tmpVec;
        }
		public IMathVector MultiplyNumber(double number)
        {
			IMathVector tmpVec = new MathVector(_dimensionscount, 0);
			for (int i = 0; i < _dimensionscount; i++)
			{
				tmpVec[i] = _arr[i] * number;
			}
			return tmpVec;
		}
		public IMathVector Sum(IMathVector vector)
        {
			IMathVector tmpVec = new MathVector(_dimensionscount, 0);
			if (vector.Dimensions!=_dimensionscount)
            {
				throw new Exception("Вектора разных размерностей");
            }
			else
            {
				for (int i = 0; i < _dimensionscount; i++)
				{
					tmpVec[i] = _arr[i] + vector[i];
				}
			}
			return tmpVec;
		}

		public IMathVector Multiply(IMathVector vector)
        {

			IMathVector tmpVec = new MathVector(_dimensionscount, 0);
			if (vector.Dimensions != _dimensionscount)
			{
				throw new Exception("Вектора разных размерностей");
			}
			else
			{
				for (int i = 0; i < _dimensionscount; i++)
				{
					tmpVec[i] = _arr[i] * vector[i];
				}
			}
			return tmpVec;
		}
		public double ScalarMultiply(IMathVector vector)
		{
			double res=0;
			if (vector.Dimensions != _dimensionscount)
			{
				throw new Exception("Вектора разных размерностей");
			}
			else
			{
				for (int i = 0; i < _dimensionscount; i++)
				{
					res = _arr[i] * vector[i];
				}
			}
			return res;
		}
		public double CalcDistance(IMathVector vector)
        {
			double res = 0;
			if (vector.Dimensions != _dimensionscount)
			{
				throw new Exception("Вектора разных размерностей");
			}
			else
			{
				for (int i = 0; i < _dimensionscount; i++)
				{
					res =res+ (_arr[i]- vector[i])* (_arr[i] - vector[i]);
				}
			}
			return Math.Sqrt(res);
        }
		public static IMathVector operator +(MathVector vector,double number)
        {
			
			return vector.SumNumber(number) ;
        }
		public static IMathVector operator +(double number, MathVector vector)
		{

			return vector.SumNumber(number);
		}

		public static IMathVector operator +(MathVector vector1, MathVector vector2)
		{

			return vector1.Sum(vector2);
		}

		public static IMathVector operator -(MathVector vector, double number)
		{
			number = number * (-1);
			return vector.SumNumber(number);
		}
		public static IMathVector operator -(MathVector vector1, MathVector vector2)
		{
			vector2=(MathVector)vector2.MultiplyNumber(-1);
			return vector1.Sum(vector2);
		}

		public static IMathVector operator *(MathVector vector1, double number)
		{
			return vector1.MultiplyNumber(number);
		}
		public static IMathVector operator *(double number, MathVector vector1)
		{
			return vector1.MultiplyNumber(number);
		}

		public static IMathVector operator *(MathVector vector1, MathVector vector2)
		{		
			return vector1.Multiply(vector2);
		}

		public static IMathVector operator /(MathVector vector1, double number)
		{
			if (number == 0)
			{
				throw new Exception("Деление на ноль");
			} 
			else
            {
				return vector1.MultiplyNumber(1 / number);
			}	
		}

		public static IMathVector operator /(MathVector vector1, MathVector vector2)
		{
			MathVector tmpVec = new MathVector(vector2.Dimensions, 0);
			tmpVec = vector2;
			for (int i = 0; i < vector2.Dimensions; i++)
			{
                if (vector2[i]==0)
                {
					throw new Exception("Деление на ноль");
				}  
				else
                {
					vector2[i] = 1 / vector2[i];
					
                }		
			}
			return vector1.Multiply(vector2);
		}

		public static double operator %(MathVector vector1, MathVector vector2)
		{
			//vector2 = vector2.MultiplyNumber(-1);
			return vector1.ScalarMultiply(vector2);
		}
		
		public IEnumerator GetEnumerator()
        {
			return (IEnumerator)GetEnumerator();
		}
	}
		
}
