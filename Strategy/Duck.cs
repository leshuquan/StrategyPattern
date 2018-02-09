using System;

namespace Strategy
{
	public abstract class Duck
	{
		protected FlyBehavior flyBehavior;
		protected QuackBehavior quackBehavior;

		public Duck ()
		{
		}

		public void Swim(){
			Console.WriteLine ("I can swimming!");
		}

		public abstract void Display ();

		public void PerformFly(){
			flyBehavior.Fly ();
		}

		public void PerformQuack(){
			quackBehavior.QuackMetho ();
		}

		public void SetPerformFly(FlyBehavior flyBehavior){
			
		}

		public void SetPerformQuack(QuackBehavior quackBehavior){
		
		}
	}
}

