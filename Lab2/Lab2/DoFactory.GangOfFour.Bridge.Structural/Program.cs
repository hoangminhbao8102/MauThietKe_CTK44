using System;

namespace DoFactory.GangOfFour.Bridge.Structural
{
	class MainApp
	{
		static void Main()
		{
			Abstraction ab = new RefinedAbstraction();

			ab.Implementor = new ConcreteImplementorA();
			ab.Operation();

			ab.Implementor = new ConcreteImplementorB();
			ab.Operation();

			Console.ReadKey();
		}
	}

	class Abstraction
	{
		protected Implementor implementor;
		public Implementor Implementor
		{
			set { implementor = value; }
		}
		public virtual void Operation()
		{
			implementor.Operation();
		}
	}

	abstract class Implementor
	{
		public abstract void Operation();
	}

	class RefinedAbstraction : Abstraction
	{
		public override void Operation()
		{
			implementor.Operation();
		}
	}

	class ConcreteImplementorA : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorA Operation");
		}
	}

	class ConcreteImplementorB : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorB Operation");
		}
	}
}