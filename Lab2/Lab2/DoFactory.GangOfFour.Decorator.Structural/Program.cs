﻿using System;

namespace DoFactory.GangOfFour.Decorator.Structural
{
	class MainApp
	{
		static void Main()
		{
			ConcreteComponent c = new ConcreteComponent();
			ConcreteDecoratorA d1 = new ConcreteDecoratorA();
			ConcreteDecoratorB d2 = new ConcreteDecoratorB();

			d1.SetComponent(c);
			d2.SetComponent(d1);

			d2.Operation();

			Console.ReadKey();
		}
	}

	abstract class Component
	{
		public abstract void Operation();
	}

	class ConcreteComponent : Component
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteComponent.Operation()");
		}
	}

	abstract class Decorator : Component
	{
		protected Component component;
		public void SetComponent(Component component)
		{
			this.component = component;
		}
		public override void Operation()
		{
			if (component != null)
			{
				component.Operation();
			}
		}
	}

	class ConcreteDecoratorA : Decorator
	{
		public override void Operation()
		{
			base.Operation();
			Console.WriteLine("ConcreteDecorationA.Operation()");
		}
	}

	class ConcreteDecoratorB : Decorator
	{
		public override void Operation()
		{
			base.Operation();
			AddedBehavior();
			Console.WriteLine("ConcreteDecorationB.Operation()");
		}
		void AddedBehavior()
		{

		}
	}
}