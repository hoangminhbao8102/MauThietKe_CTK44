﻿using System;
using System.Runtime.CompilerServices;

namespace DoFactory.GangOfFour.Strategy.Structural
{
    class MainApp
    {
        static void Main()
        {
            Context context;

            context - new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context - new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context - new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }

    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

    class Context
    {
        public Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}