using System;

namespace Strategy
{
	public class Quack:QuackBehavior
	{
		#region QuackBehavior implementation

		public void QuackMetho ()
		{
			Console.WriteLine ("呱呱呱~");
		}

		#endregion

		public Quack ()
		{
		}
	}
}

