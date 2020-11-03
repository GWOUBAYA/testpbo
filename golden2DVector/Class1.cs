using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golden2DVector
{
	/// <summary>
	/// This class is for the Vector calculator 
	/// </summary>
	public class golden2D
	{
		#region Data Member
		private int x;
		private int y;

		public int Y
		{
			get { return y; }
			set { y = value; }
		}


		public int X
		{
			get { return x; }
			set { x = value; }
		}
		#endregion
		#region Constructor
		public golden2D(int inputX, int inputY)
		{
			this.X = inputX;
			this.Y = inputY;
		}
		public golden2D()
		{
			this.X = 1;
			this.Y = 1;
		}
		#endregion
		#region Method
		public golden2D Addition(golden2D inputGolden2D)
		{
			golden2D result = new golden2D();
			result.X = this.X + inputGolden2D.X;
			result.Y = this.Y + inputGolden2D.Y;
			return result;
		}
		public golden2D Addition(int inputX, int inputY)
		{
			golden2D result = new golden2D();
			result.X = this.X + inputX;
			result.Y = this.Y + inputY;
			return result;
		}
		public golden2D Subtract(golden2D inputGolden2D)
		{
			golden2D result = new golden2D();
			result.X = this.X - inputGolden2D.X;
			result.Y = this.Y - inputGolden2D.Y;
			return result;
		}
		public golden2D Subtract(int inputX, int inputY)
		{
			golden2D result = new golden2D();
			result.X = this.X - inputX;
			result.Y = this.Y - inputY;
			return result;
		}
		public int DotProduct(golden2D inputGolden2D)
		{
			int result = this.X * inputGolden2D.X;
			result += (this.Y * inputGolden2D.Y);
			return result;
		}
		public int DotProduct(int inputX, int inputY)
		{
			int result = this.X * inputX;
			result += (this.Y * inputY);
			return result;
		}
		public golden2D ScalarMult(int input)
		{
			golden2D result = new golden2D();
			result.X = this.X * input;
			result.Y = this.Y * input;
			return result;
		}
		public golden2D ScalarDiv(int input)
		{
			if (input > 0)
			{
				golden2D result = new golden2D();
				result.X = this.X / input;
				result.Y = this.Y / input;
				return result;
			}
			else
			{
				throw new Exception("Please input the correct value");
			}
		}
		public double Norm()
		{
			double test = Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
			return test;
		}
		#endregion
	}


}
