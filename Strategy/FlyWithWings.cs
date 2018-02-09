using System;

namespace Strategy
{
	public class FlyWithWings:FlyBehavior
	{
		#region FlyBehavior implementation

		public void Fly ()
		{
			Console.WriteLine ("I can fly with wings!");
		}

		#endregion

		public FlyWithWings ()
		{
		}
	}
}

