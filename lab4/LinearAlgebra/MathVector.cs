using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorException;


namespace LinearAlgebra
{
	/// <inferitdoc cref="IMathVector"/>
	public class MathVector : IMathVector
	{
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
			if (size > 0)
			{
				_dimensionscount = size;
				_capacity = _dimensionscount * 2;
				_arr = new double[_capacity];
				for (int i = 0; i != size; ++i)
					_arr[i] = value;
			}
			else
			{
				throw new VectorSizeException("Некорретная размерность вектора");
			}
		}
		public MathVector(List<double> arr)
        {
			_dimensionscount = arr.Count;
			_capacity = _dimensionscount * 2;
			_arr = new double[_capacity];
			for (int i = 0; i != _dimensionscount; ++i)
				_arr[i] = arr[i];
		}
		public MathVector(params int[] arr)
		{
			_dimensionscount = arr.Length;
			_capacity = _dimensionscount * 2;
			_arr = new double[_capacity];
			for (int i = 0; i != _dimensionscount; ++i)
				_arr[i] = arr[i];
		}
		public MathVector(string[] arr)
		{
			_dimensionscount = arr.Length;
			_capacity = _dimensionscount * 2;
			_arr = new double[_capacity];
			for (int i = 0; i != _dimensionscount; ++i)
				_arr[i] = Convert.ToDouble(arr[i]);
		}
		public MathVector(int size)
		{
			if (size > 0)
			{
				_dimensionscount = size;
				_capacity = _dimensionscount * 2;
				_arr = new double[_capacity];
				for (int i = 0; i != size; ++i)
					_arr[i] = Convert.ToDouble(Console.ReadLine());
			}
			else
			{
				throw new VectorSizeException("Некорретная размерность вектора");
			}

		}

		
		public MathVector(IMathVector vector)
		{
			_dimensionscount = vector.Dimensions;
			_capacity = vector.Dimensions * 2;
			_arr = new double[_capacity];
			for (int i = 0; i != vector.Dimensions; ++i)
				_arr[i] = vector[i];
		}
        public override bool Equals(object other)
        {
			bool result = true;
			var toCompareWith = other as IMathVector;
			if (this.Dimensions != toCompareWith.Dimensions)
            {
				 result = false;
            }
			else
            {
				for(int i= 0; i<this.Dimensions;i++)
                {
					if (this[i] != toCompareWith[i])
                    {
						result = false;
                    }
                }

			}
			return result;
		}
        public void OutputVec()
		{
			string str = "";
			for (int i = 0; i < _dimensionscount; i++)
			{
				str = str + _arr[i];
			}
			Console.WriteLine(str);
		}
		public void ClearVec()
		{
			string str = "";
			for (int i = 0; i < _dimensionscount; i++)
			{
				 _arr[i]=0;
			}
			Console.WriteLine(str);
		}
		public int Dimensions
		{
			get { return _dimensionscount; }
		}

		public double this[int i]
		{
			get { return _arr[i]; }
			set { _arr[i] = value; }
		}

		public double Length
		{
			get
			{
				double summS = 0;
				for (int i = 0; i < _dimensionscount; i++)
				{

					summS = summS + (_arr[i] * _arr[i]);
				}
				return Math.Sqrt(summS);
			}
		}
		public IMathVector SumNumber(double number)
		{
			IMathVector tmpVec = new MathVector(_dimensionscount, 0);
			for (int i = 0; i < _dimensionscount; i++)
			{
				tmpVec[i] = _arr[i] + number;
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
			if (vector.Dimensions != _dimensionscount)
			{
				throw new VectorSizeException("Некорретная размерность вектора");
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
				throw new VectorSizeException("Некорретная размерность вектора");
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
			double res = 0;

			if (vector.Dimensions != _dimensionscount)
			{
				throw new VectorSizeException("Некорретная размерность вектора");
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
				throw new VectorSizeException("Некорретная размерность вектора");
			}
			else
			{
				for (int i = 0; i < _dimensionscount; i++)
				{
					res += (_arr[i] - vector[i]) * (_arr[i] - vector[i]);
				}
			}
			return Math.Sqrt(res);
		}
		public static IMathVector operator +(MathVector vector, double number)
		{

			return vector.SumNumber(number);
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
			vector2 = (MathVector)vector2.MultiplyNumber(-1);
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
				throw new VectorMathException("Деление на ноль");
			}
			else
			{
				return vector1.MultiplyNumber(1 / number);
			}
		}

		public static IMathVector operator /(MathVector vector1, MathVector vector2)
		{
			MathVector tmpVec = new MathVector(vector2);
			for (int i = 0; i < vector2.Dimensions; i++)
			{
				if (vector2[i] == 0)
				{
					throw new VectorMathException("Деление на ноль");
				}
				else
				{
					tmpVec[i] = 1 / vector2[i];

				}
			}
			return vector1.Multiply(tmpVec);
		}

		public static double operator %(MathVector vector1, MathVector vector2)
		{
			return vector1.ScalarMultiply(vector2);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}
	}

}