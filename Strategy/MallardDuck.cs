using System;

namespace Strategy
{
	public class MallardDuck:Duck
	{
		#region implemented abstract members of Duck

		public override void Display ()
		{
			Console.WriteLine ("I'm a green-head-duck!");
		}

		#endregion

		public MallardDuck ()
		{
			flyBehavior = new FlyWithWings ();
			quackBehavior = new Quack ();
		}
	}
}

