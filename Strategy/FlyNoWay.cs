using System;

namespace Strategy
{
	public class FlyNoWay : FlyBehavior
	{
		#region FlyBehavior implementation

		public void Fly ()
		{
			Console.WriteLine ("I can't fly!");
		}

		#endregion

		public FlyNoWay ()
		{
		}

	}
}

