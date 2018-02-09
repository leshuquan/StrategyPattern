using System;

namespace Strategy
{
	public class Squeak:QuackBehavior
	{
		#region QuackBehavior implementation

		public void QuackMetho ()
		{
			Console.WriteLine ("吱吱吱~");
		}

		#endregion

		public Squeak ()
		{
		}
	}
}

