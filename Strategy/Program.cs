using System;

namespace Strategy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Duck mallardDuck = new MallardDuck ();
			mallardDuck.PerformFly ();
			mallardDuck.PerformQuack ();
		}
	}
}
